using buttonHelper;
using CatCaha.NewFolder1;
using CatCha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatChaForms;


namespace Cart2
{
    public partial class Frm_Cart2 : Form
    {
        public Frm_Cart2()
        {
            InitializeComponent();
            //0.在選擇運送前，先不啟用輸入地址的所有控制項
            this.txtRecipientName.Enabled
                   = this.txtRecipientPhone.Enabled
                   = this.txtRecipientAddress.Enabled
                   = this.cmbCommonAddress.Enabled
                   = false;
            //0.button顏色
            this.btnSendOrder.BackColor = ColorTranslator.FromHtml("#E4BB97");
        }

        project123Entities dbContext = new project123Entities();
        int memberID = LoggedInUser.ID;
        //int orderState = 1;

        List<CarttoBill> listToBill = new List<CarttoBill>();
        const decimal MaxPointsValue = 0.1M;

        #region 1.開啟時
        private void CartDetailsPage_Load(object sender, EventArgs e)
        {
            
            //1.常用地址
            //(a)撈到該會員的常用地址資料
            var selectAddress =from a in dbContext.Shop_Common_Address_Data.AsEnumerable()
                   where a.Member_ID== memberID
                               select new { a.Recipient_Name, a.Recipient_Phone ,a.Recipient_Address };
            //(b)姓名.手機.地址各自加入ComboBox
            foreach (var i in selectAddress)
            {
                string recipient = $"{i.Recipient_Name}/{i.Recipient_Phone}/{i.Recipient_Address}";
                this.cmbCommonAddress.Items.Add(recipient);
            }

            
            //2.訂單明細資料
            //(a).查詢符合訂單ID的訂單明細，其中產品

            var listCartDetails = from p in dbContext.Shop_Product_Total
                     from od in p.Shop_Order_Detail_Table
                     where  od.Shop_Order_Total_Table.Member_ID== memberID && od.Shop_Order_Total_Table.Order_Status_ID==1
                     select new { 商品名稱 = p.Product_Name, 商品價格 = p.Product_Price.Value, 商品數量 = od.Product_Quantity.Value };
            //把資料加進list裡
            
            foreach (var item in listCartDetails)
            { 
            CarttoBill ctb = new CarttoBill();
                ctb.productName = item.商品名稱;
                ctb.productCount =Convert.ToString(item.商品數量);
                ctb.productPrice = item.商品價格;
                listToBill.Add(ctb);
            }
            ////把資料傳給Frm_Cart3
            //Frm_Cart3 frm_Cart3 = new Frm_Cart3();
            //frm_Cart3.LoadCartItem(listToBill);

            //(b)加入dgv
            this.dgvCartList.DataSource = listCartDetails.ToList();
            this.dgvCartList.RowTemplate.DefaultCellStyle.SelectionBackColor=ColorTranslator.FromHtml("#FEF5EF");
            //(c)取得小計
            foreach (var i in listCartDetails)
            {
                CarttoBill.CartTotal += i.商品價格 * i.商品數量;
                this.labCartTotal.Text = $"商品小計 $NT {CarttoBill.CartTotal}";
               
            }

            //3.會員優惠券，加入cmb
            //(a)撈到該會員的優惠券資料
            //可用條件:1.Usable==true(未被領完)2.擁有該優惠券3.Coupon_Status_ID==false(未使用)
            var selectCoupon = from c in dbContext.Shop_Member_Coupon_Data.AsEnumerable()
                    where c.Member_ID == memberID&& c.Shop_Coupon_Total.Usable == true && c.Coupon_ID==c.Shop_Coupon_Total.Coupon_ID&&c.Coupon_Status_ID==false
                    select c.Shop_Coupon_Total.Coupon_Content;

            this.cmbSelectCoupon.Items.Add("不使用");
            //(b)加入ComboBox
            foreach (var i in  selectCoupon)
            {
                this.cmbSelectCoupon.Items.Add(i);
            }
            this.cmbSelectCoupon.SelectedIndex = 0;


            //4.加入付款方式
            //(a)撈到所有付款方式
            var selectPaymentMethod = from p in dbContext.Shop_Payment_Method_Data.AsEnumerable()
                               select p.Payment_Method_Name;
            //(b)加入ComboBox
            this.cmbSelectPaymentMethod.DataSource = selectPaymentMethod.ToList();

            //5.提醒使用紅利

            var points = (from m in this.dbContext.Shop_Member_Info.AsEnumerable()
                          where m.Member_ID == memberID 
                          select m.Loyalty_Points.Value).FirstOrDefault();
            if (PointsExchangeMoney(points) <1)
            {
                this.ckbUseLoyaltyPoints.Enabled = false;
                CarttoBill.Points = points;
                CarttoBill.PointsValue = PointsExchangeMoney(CarttoBill.Points);
                this.ckbUseLoyaltyPoints.Text = $"紅利折抵金額小於NT$ 1，無法使用紅利點數折抵";

            }
            else
            {
                CarttoBill.Points = points;
                CarttoBill.PointsValue = PointsExchangeMoney(CarttoBill.Points);
                this.ckbUseLoyaltyPoints.Text = $"使用 {CarttoBill.PointsValue * 1000} 點紅利點數折抵 NT$ {CarttoBill.PointsValue:c2}";
            }


            //6.先計算運費+小計總金額(loading 預設沒有選擇使用紅利與優惠券)
            CarttoBill.OrderTotal = Convert.ToInt32(CarttoBill.CartTotal + CarttoBill.Shippment);
            this.labOrderTotal.Text= $"總計 {CarttoBill.OrderTotal:c2}";

            //7.提醒可獲多少紅利
            this.labNote.Text=this.labNote2.Text=$"可獲得{CarttoBill.CartTotal * 1000} 紅利";

        }
        #endregion

        #region 紅利換匯(1000紅利折抵1元，1元累積1000點紅利)
        

        public decimal PointsExchangeMoney(decimal points)
        {
            
            decimal moneyExchangedByPoints = points / 1000;

            if (moneyExchangedByPoints >= CarttoBill.CartTotal * MaxPointsValue)
            {
                moneyExchangedByPoints = CarttoBill.CartTotal * MaxPointsValue;
                
            }
            return moneyExchangedByPoints;
        }

        #endregion


        #region 2.紅利勾選動作:勾選是否使用紅利的動作處理
        public void UsingLoyaltyPoints(bool isUsing)
        {
            if (isUsing)
            {

                CarttoBill.PointsValue = PointsExchangeMoney(CarttoBill.Points);
            }
            else
            {
                CarttoBill.PointsValue = 0;
            }
        }

        private void ckbUseLoyaltyPoints_CheckedChanged(object sender, EventArgs e)
        {
            //取消勾選時總金額計算

            UsingLoyaltyPoints(this.ckbUseLoyaltyPoints.Checked);
            CarttoBill.OrderTotal = Convert.ToInt32(CarttoBill.CartTotal + CarttoBill.Shippment - CarttoBill.PointsValue - CarttoBill.Discount);

            this.labLoyaltyPointsValue.Text = $"紅利折抵 - {CarttoBill.PointsValue:c2}";
            this.labOrderTotal.Text = $"總計 {CarttoBill.OrderTotal}";
            
        }
        #endregion

        #region 3.地址勾選動作: 選擇何種地址填寫方式
        //(1)同會員資料
        private void recipientAsMemberInfo_CheckedChanged(object sender, EventArgs e)
        {
            //取消勾選時
            this.txtRecipientName.Text
                = this.txtRecipientPhone.Text
                = this.txtRecipientAddress.Text = "";
            this.txtRecipientName.Enabled
                    = this.txtRecipientPhone.Enabled
                    = this.txtRecipientAddress.Enabled
                    = true;

            //勾選時顯示memberinfo中的name.phone.address欄位資料，常用地址不可選擇
            var asMemberInfo = from m in dbContext.Shop_Member_Info.AsEnumerable()
                               where m.Member_ID == memberID
                               select new { m.Name, m.Phone_Number, m.Address };
            if (this.recipientAsMemberInfo.Checked)
            {
                foreach (var m in asMemberInfo)
                {
                    this.txtRecipientName.Text = m.Name;
                    this.txtRecipientPhone.Text = m.Phone_Number;
                    this.txtRecipientAddress.Text = m.Address;
                }
                this.txtRecipientName.Enabled = this.txtRecipientPhone.Enabled = this.txtRecipientAddress.Enabled = false;
                this.cmbCommonAddress.Enabled = false;
                this.cmbCommonAddress.SelectedItem = null;

            }
        }

        //(2)同常用地址
        private void recipientAsCommonAddress_CheckedChanged(object sender, EventArgs e)
        {
            //取消勾選時txtbox可以輸入
            this.txtRecipientName.Text
                = this.txtRecipientPhone.Text
                = this.txtRecipientAddress.Text = "";
            this.txtRecipientName.Enabled
                    = this.txtRecipientPhone.Enabled
                    = this.txtRecipientAddress.Enabled
                    = true;
            this.cmbCommonAddress.SelectedItem = null;

            //勾選時txtbox不可輸入，且常用地址可輸入
            if (this.recipientAsCommonAddress.Checked)
            {
                this.cmbCommonAddress.Enabled = true;
                this.txtRecipientName.Enabled = this.txtRecipientPhone.Enabled = this.txtRecipientAddress.Enabled = false;
            }
        }
        //(3)自訂地址
        private void recipientInputAddress_CheckedChanged(object sender, EventArgs e)
        {
            //取消勾選時不可以輸入
            this.cmbCommonAddress.Enabled = true;
            //勾選時常用地址不可選擇，且txtbox可輸入
            if (this.recipientInputAddress.Checked)
            {
                this.cmbCommonAddress.Enabled = false;
                this.txtRecipientName.Text
                = this.txtRecipientPhone.Text
                = this.txtRecipientAddress.Text = "";
                this.txtRecipientName.Enabled
                        = this.txtRecipientPhone.Enabled
                        = this.txtRecipientAddress.Enabled
                        = true;
                this.cmbCommonAddress.SelectedItem = null;

            }
        }
        #endregion
        #region 4.優惠券使用條件.面額

        private void cmbSelectCoupon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //判斷是否勾選紅利欄位
            UsingLoyaltyPoints(this.ckbUseLoyaltyPoints.Checked);
            CarttoBill.Discount = CouponValue((string)this.cmbSelectCoupon.SelectedItem);
            CarttoBill.OrderTotal = Convert.ToInt32(CarttoBill.CartTotal + CarttoBill.Shippment - CarttoBill.PointsValue - CarttoBill.Discount);
           
            this.labCouponValue.Text = $"優惠券折抵 - {CarttoBill.Discount:c2}";
            this.labOrderTotal.Text = $"總計 {CarttoBill.OrderTotal}";

        }
        //判斷選到的優惠券應折抵金額
        public int CouponValue(string couponContent)
        {
            var q=(from c in this.dbContext.Shop_Coupon_Total.AsEnumerable()
                  where c.Coupon_Content== couponContent
                  select c.Coupon_ID).FirstOrDefault();

            switch (q)
            {
                case 2:
                    if (CarttoBill.CartTotal >= 500)
                    {
                        return 10;
                    }
                    else
                    {
                        MessageBox.Show("未達優惠券使用門檻");
                        this.cmbSelectCoupon.SelectedIndex = 0;
                    }
                    break;

                case 3:
                    if (CarttoBill.CartTotal >= 1000)
                    {
                        return 50;
                    }
                    else
                    {
                        MessageBox.Show("未達優惠券使用門檻");
                        this.cmbSelectCoupon.SelectedIndex = 0;
                    }
                    break;
            }
            return 0;
        }
        #endregion
        #region 5.送出訂單

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            //1.判斷地址填寫狀況update 資料庫
            //狀況(1)地址若沒有選擇不可送出訂單
            if ((this.txtRecipientName.Text == "" || this.txtRecipientPhone.Text == "" || this.txtRecipientAddress.Text == "")&& (this.cmbCommonAddress.Text == ""))
            {
                MessageBox.Show("請輸入運送資訊");
            }
            //狀況(2)手機有填寫但填寫錯誤
            else if (this.txtRecipientPhone.Text != ""&&!Regex.IsMatch($"{this.txtRecipientPhone.Text}", @"^09[0-9]{8}$"))
            {
                MessageBox.Show("請輸入正確的手機號碼");
            }
            //狀況(3)填寫正確，區分選擇何種方式，將運送資料update 至資料庫中
            else
            {
                //查詢該會員到該筆order資料
                //條件1符合登入會員ID
                //條件2該訂單狀態為1(處理中)
                var orderInfo = (from o in this.dbContext.Shop_Order_Total_Table
                                where o.Member_ID == memberID/*member id變數*/ && o.Order_Status_ID == 1
                                select o).FirstOrDefault();

                //a.選擇同會員或自訂時:
                if (this.recipientAsMemberInfo.Checked || this.recipientInputAddress.Checked)
                {
                    orderInfo.Recipient_Name = this.txtRecipientName.Text;
                    orderInfo.Recipient_Phone = this.txtRecipientPhone.Text;
                    orderInfo.Recipient_Address = this.txtRecipientAddress.Text;
                }
                //b.選擇常用地址時:
                else if (this.recipientAsCommonAddress.Checked)
                {
                    var commonAddress = from a in dbContext.Shop_Common_Address_Data
                                        where a.Member_ID == memberID
                                        select a;

                    foreach (var i in commonAddress)
                    {
                        string address = $"{i.Recipient_Name}/{i.Recipient_Phone}/{i.Recipient_Address}";
                        //如果選到的是和某常用地址相同的地址->取得該常用地址ID->更新到訂單中
                        if ((string)this.cmbCommonAddress.SelectedItem == address)
                        {
                            orderInfo.Address_ID = i.Address_ID;
                            //例外錯誤:其他交易在執行緒中
                            //this.dbContext.SaveChanges();
                        }
                    }
                    
                }
                //2.update優惠券資料到該order 資料中
                var coupon = from c in dbContext.Shop_Member_Coupon_Data
                             where c.Member_ID == memberID/*member id變數*/
                             select c;

                foreach (var i in coupon)
                {
                    //如果選到的是優惠券x->取得該優惠券ID->更新到訂單中->會員優惠券使用狀態更新為true
                    if ((string)this.cmbSelectCoupon.SelectedItem ==i.Shop_Coupon_Total.Coupon_Content )
                    {
                        orderInfo.Coupon_ID = i.Coupon_ID;
                        //使用狀態更新為true(表示已使用)
                        i.Coupon_Status_ID = true;
                    }
                    else
                    {
                        orderInfo.Coupon_ID =null;
                    }
                }

                //3.update 付款方式
                var payment = from p in dbContext.Shop_Payment_Method_Data
                             select p;

                foreach (var i in payment)
                {
                    string paymentMethod = $"{i.Payment_Method_Name}";

                   
                    if ((string)this.cmbSelectPaymentMethod.SelectedItem == paymentMethod)
                    {
                        orderInfo.Payment_Method_ID = i.Payment_Method_ID;
                        CarttoBill.PaymentMethod= paymentMethod;

                    }
                }
                
                //memberinfo扣掉使用的紅利點數
                if (this.ckbUseLoyaltyPoints.Checked)
                {
                    orderInfo.Shop_Member_Info.Loyalty_Points= orderInfo.Shop_Member_Info.Loyalty_Points-Convert.ToInt32(CarttoBill.PointsValue * 1000);
                }
                orderInfo.Shop_Member_Info.Loyalty_Points += Convert.ToInt32(CarttoBill.CartTotal * 1000);

                //order最後更新時間
                orderInfo.Last_Update_Time = DateTime.Now;

                var total = this.labOrderTotal.Text;


                Frm_Cart3 frmCart3 = new Frm_Cart3(/*listToBill,total*/);
                frmCart3.LoadCartItem(listToBill,total);
                frmCart3.Show();

                //把訂單狀態更新為2
                orderInfo.Order_Status_ID = 2;
                this.dbContext.SaveChanges();

            }
        }
        #endregion

        
    }
}
