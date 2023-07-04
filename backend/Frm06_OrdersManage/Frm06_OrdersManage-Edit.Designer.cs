namespace CatChaEntities
{
    partial class Frm06_OrdersManage_Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label member_IDLabel;
            System.Windows.Forms.Label order_IDLabel;
            System.Windows.Forms.Label order_Creation_DateLabel;
            System.Windows.Forms.Label last_Update_TimeLabel;
            System.Windows.Forms.Label address_IDLabel;
            System.Windows.Forms.Label order_Status_IDLabel;
            System.Windows.Forms.Label payment_Method_IDLabel;
            System.Windows.Forms.Label coupon_IDLabel;
            this.txtMember_ID = new System.Windows.Forms.TextBox();
            this.txtOrder_ID = new System.Windows.Forms.TextBox();
            this.dtpOrder_Creation_Time = new System.Windows.Forms.DateTimePicker();
            this.dtpLast_Update_Time = new System.Windows.Forms.DateTimePicker();
            this.txtAddress_ID = new System.Windows.Forms.TextBox();
            this.txtOrder_Status_ID = new System.Windows.Forms.TextBox();
            this.txtPayment_Method_ID = new System.Windows.Forms.TextBox();
            this.txtCoupon_ID = new System.Windows.Forms.TextBox();
            this.txtUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.shop_Order_Total_TableTableAdapter = new CatChaEntities.catchaDataSetTableAdapters.Shop_Order_Total_TableTableAdapter();
            this.shop_Order_Total_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catchaDataSet = new CatChaEntities.catchaDataSet();
            this.tableAdapterManager = new CatChaEntities.catchaDataSetTableAdapters.TableAdapterManager();
            member_IDLabel = new System.Windows.Forms.Label();
            order_IDLabel = new System.Windows.Forms.Label();
            order_Creation_DateLabel = new System.Windows.Forms.Label();
            last_Update_TimeLabel = new System.Windows.Forms.Label();
            address_IDLabel = new System.Windows.Forms.Label();
            order_Status_IDLabel = new System.Windows.Forms.Label();
            payment_Method_IDLabel = new System.Windows.Forms.Label();
            coupon_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shop_Order_Total_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catchaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // member_IDLabel
            // 
            member_IDLabel.AutoSize = true;
            member_IDLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            member_IDLabel.Location = new System.Drawing.Point(41, 28);
            member_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            member_IDLabel.Name = "member_IDLabel";
            member_IDLabel.Size = new System.Drawing.Size(66, 17);
            member_IDLabel.TabIndex = 1;
            member_IDLabel.Text = "會員編號 :";
            // 
            // order_IDLabel
            // 
            order_IDLabel.AutoSize = true;
            order_IDLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            order_IDLabel.Location = new System.Drawing.Point(41, 87);
            order_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            order_IDLabel.Name = "order_IDLabel";
            order_IDLabel.Size = new System.Drawing.Size(66, 17);
            order_IDLabel.TabIndex = 3;
            order_IDLabel.Text = "訂單編號 :";
            // 
            // order_Creation_DateLabel
            // 
            order_Creation_DateLabel.AutoSize = true;
            order_Creation_DateLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            order_Creation_DateLabel.Location = new System.Drawing.Point(41, 146);
            order_Creation_DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            order_Creation_DateLabel.Name = "order_Creation_DateLabel";
            order_Creation_DateLabel.Size = new System.Drawing.Size(92, 17);
            order_Creation_DateLabel.TabIndex = 5;
            order_Creation_DateLabel.Text = "訂單成立日期 :";
            // 
            // last_Update_TimeLabel
            // 
            last_Update_TimeLabel.AutoSize = true;
            last_Update_TimeLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            last_Update_TimeLabel.Location = new System.Drawing.Point(41, 205);
            last_Update_TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            last_Update_TimeLabel.Name = "last_Update_TimeLabel";
            last_Update_TimeLabel.Size = new System.Drawing.Size(105, 17);
            last_Update_TimeLabel.TabIndex = 7;
            last_Update_TimeLabel.Text = "訂單最後更新日 :";
            // 
            // address_IDLabel
            // 
            address_IDLabel.AutoSize = true;
            address_IDLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            address_IDLabel.Location = new System.Drawing.Point(41, 264);
            address_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            address_IDLabel.Name = "address_IDLabel";
            address_IDLabel.Size = new System.Drawing.Size(92, 17);
            address_IDLabel.TabIndex = 9;
            address_IDLabel.Text = "常用地址編號 :";
            // 
            // order_Status_IDLabel
            // 
            order_Status_IDLabel.AutoSize = true;
            order_Status_IDLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            order_Status_IDLabel.Location = new System.Drawing.Point(41, 323);
            order_Status_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            order_Status_IDLabel.Name = "order_Status_IDLabel";
            order_Status_IDLabel.Size = new System.Drawing.Size(92, 17);
            order_Status_IDLabel.TabIndex = 11;
            order_Status_IDLabel.Text = "訂單狀態編號 :";
            // 
            // payment_Method_IDLabel
            // 
            payment_Method_IDLabel.AutoSize = true;
            payment_Method_IDLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            payment_Method_IDLabel.Location = new System.Drawing.Point(41, 382);
            payment_Method_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            payment_Method_IDLabel.Name = "payment_Method_IDLabel";
            payment_Method_IDLabel.Size = new System.Drawing.Size(92, 17);
            payment_Method_IDLabel.TabIndex = 17;
            payment_Method_IDLabel.Text = "付款方式編號 :";
            // 
            // coupon_IDLabel
            // 
            coupon_IDLabel.AutoSize = true;
            coupon_IDLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            coupon_IDLabel.Location = new System.Drawing.Point(41, 441);
            coupon_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            coupon_IDLabel.Name = "coupon_IDLabel";
            coupon_IDLabel.Size = new System.Drawing.Size(79, 17);
            coupon_IDLabel.TabIndex = 18;
            coupon_IDLabel.Text = "優惠券編號 :";
            // 
            // txtMember_ID
            // 
            this.txtMember_ID.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMember_ID.Location = new System.Drawing.Point(175, 25);
            this.txtMember_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMember_ID.Name = "txtMember_ID";
            this.txtMember_ID.ReadOnly = true;
            this.txtMember_ID.Size = new System.Drawing.Size(184, 25);
            this.txtMember_ID.TabIndex = 2;
            // 
            // txtOrder_ID
            // 
            this.txtOrder_ID.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrder_ID.Location = new System.Drawing.Point(175, 84);
            this.txtOrder_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrder_ID.Name = "txtOrder_ID";
            this.txtOrder_ID.ReadOnly = true;
            this.txtOrder_ID.Size = new System.Drawing.Size(184, 25);
            this.txtOrder_ID.TabIndex = 4;
            // 
            // dtpOrder_Creation_Time
            // 
            this.dtpOrder_Creation_Time.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpOrder_Creation_Time.Location = new System.Drawing.Point(175, 144);
            this.dtpOrder_Creation_Time.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpOrder_Creation_Time.Name = "dtpOrder_Creation_Time";
            this.dtpOrder_Creation_Time.Size = new System.Drawing.Size(184, 25);
            this.dtpOrder_Creation_Time.TabIndex = 6;
            // 
            // dtpLast_Update_Time
            // 
            this.dtpLast_Update_Time.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpLast_Update_Time.Location = new System.Drawing.Point(175, 202);
            this.dtpLast_Update_Time.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpLast_Update_Time.Name = "dtpLast_Update_Time";
            this.dtpLast_Update_Time.Size = new System.Drawing.Size(184, 25);
            this.dtpLast_Update_Time.TabIndex = 8;
            // 
            // txtAddress_ID
            // 
            this.txtAddress_ID.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress_ID.Location = new System.Drawing.Point(175, 260);
            this.txtAddress_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress_ID.Name = "txtAddress_ID";
            this.txtAddress_ID.Size = new System.Drawing.Size(184, 25);
            this.txtAddress_ID.TabIndex = 10;
            // 
            // txtOrder_Status_ID
            // 
            this.txtOrder_Status_ID.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrder_Status_ID.Location = new System.Drawing.Point(175, 318);
            this.txtOrder_Status_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrder_Status_ID.Name = "txtOrder_Status_ID";
            this.txtOrder_Status_ID.Size = new System.Drawing.Size(184, 25);
            this.txtOrder_Status_ID.TabIndex = 12;
            // 
            // txtPayment_Method_ID
            // 
            this.txtPayment_Method_ID.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPayment_Method_ID.Location = new System.Drawing.Point(175, 376);
            this.txtPayment_Method_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPayment_Method_ID.Name = "txtPayment_Method_ID";
            this.txtPayment_Method_ID.Size = new System.Drawing.Size(184, 25);
            this.txtPayment_Method_ID.TabIndex = 14;
            // 
            // txtCoupon_ID
            // 
            this.txtCoupon_ID.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCoupon_ID.Location = new System.Drawing.Point(175, 438);
            this.txtCoupon_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCoupon_ID.Name = "txtCoupon_ID";
            this.txtCoupon_ID.Size = new System.Drawing.Size(184, 25);
            this.txtCoupon_ID.TabIndex = 16;
            // 
            // txtUpdate
            // 
            this.txtUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.txtUpdate.Location = new System.Drawing.Point(423, 401);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(120, 57);
            this.txtUpdate.TabIndex = 19;
            this.txtUpdate.Text = "儲存資料";
            this.txtUpdate.UseVisualStyleBackColor = true;
            this.txtUpdate.Click += new System.EventHandler(this.txtUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(588, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 57);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // shop_Order_Total_TableTableAdapter
            // 
            this.shop_Order_Total_TableTableAdapter.ClearBeforeFill = true;
            // 
            // catchaDataSet
            // 
            this.catchaDataSet.DataSetName = "catchaDataSet";
            this.catchaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Game_Product_CategoryTableAdapter = null;
            this.tableAdapterManager.Game_Product_TotalTableAdapter = null;
            this.tableAdapterManager.Shop_Member_InfoTableAdapter = null;
            this.tableAdapterManager.Shop_Order_Detail_TableTableAdapter = null;
            this.tableAdapterManager.Shop_Order_Status_DataTableAdapter = null;
            this.tableAdapterManager.Shop_Order_Total_TableTableAdapter = this.shop_Order_Total_TableTableAdapter;
            this.tableAdapterManager.Shop_Product_CategoryTableAdapter = null;
            this.tableAdapterManager.Shop_Product_Image_TableTableAdapter = null;
            this.tableAdapterManager.Shop_Product_TotalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CatChaEntities.catchaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Frm06_OrdersManage_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 576);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(coupon_IDLabel);
            this.Controls.Add(payment_Method_IDLabel);
            this.Controls.Add(member_IDLabel);
            this.Controls.Add(this.txtMember_ID);
            this.Controls.Add(order_IDLabel);
            this.Controls.Add(this.txtOrder_ID);
            this.Controls.Add(order_Creation_DateLabel);
            this.Controls.Add(this.dtpOrder_Creation_Time);
            this.Controls.Add(last_Update_TimeLabel);
            this.Controls.Add(this.dtpLast_Update_Time);
            this.Controls.Add(address_IDLabel);
            this.Controls.Add(this.txtAddress_ID);
            this.Controls.Add(order_Status_IDLabel);
            this.Controls.Add(this.txtOrder_Status_ID);
            this.Controls.Add(this.txtPayment_Method_ID);
            this.Controls.Add(this.txtCoupon_ID);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm06_OrdersManage_Edit";
            this.Text = "Frm06_OrdersManage_ADD";
            ((System.ComponentModel.ISupportInitialize)(this.shop_Order_Total_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catchaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMember_ID;
        private System.Windows.Forms.TextBox txtOrder_ID;
        private System.Windows.Forms.DateTimePicker dtpOrder_Creation_Time;
        private System.Windows.Forms.DateTimePicker dtpLast_Update_Time;
        private System.Windows.Forms.TextBox txtAddress_ID;
        private System.Windows.Forms.TextBox txtOrder_Status_ID;
        private System.Windows.Forms.TextBox txtPayment_Method_ID;
        private System.Windows.Forms.TextBox txtCoupon_ID;
        private System.Windows.Forms.Button txtUpdate;
        private System.Windows.Forms.Button btnCancel;
        private catchaDataSetTableAdapters.Shop_Order_Total_TableTableAdapter shop_Order_Total_TableTableAdapter;
        private System.Windows.Forms.BindingSource shop_Order_Total_TableBindingSource;
        private catchaDataSet catchaDataSet;
        private catchaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}