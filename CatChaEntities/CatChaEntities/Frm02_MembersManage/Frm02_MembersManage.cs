using CatChaEntities.catchaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatChaEntities
{
    public partial class Frm02_MembersManage : Form
    {
        catchaEntities dbContext = new catchaEntities();
        public Frm02_MembersManage()
        {
            InitializeComponent();
            //LoadData
            var members = dbContext.Shop_Member_Info.ToList();
            this.bindingSourceM.DataSource = members;
            dataGridViewMembers.DataSource = bindingSourceM;
            //初始化DateTimePicker
            dtpFrom.Value = new DateTime(2000, 1, 1);
            dtpTo.Value = DateTime.Today;
        }

        //搜尋
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var q = from p in dbContext.Shop_Member_Info
                        select p;

                int memberID;
                if (int.TryParse(txtMemberID.Text, out memberID))
                {
                    q = q.Where(p => p.Member_ID == memberID);
                }

                string account = txtMemberAccount.Text.Trim();
                if (!string.IsNullOrEmpty(account))
                {
                    q = q.Where(p => p.Member_Account.Contains(account));
                }

                string memberName = txtMemberName.Text.Trim();
                if (!string.IsNullOrEmpty(memberName))
                {
                    q = q.Where(p => p.Name.Contains(memberName));
                }

                string characterName = txtCharacterName.Text.Trim();
                if (!string.IsNullOrEmpty(characterName))
                {
                    q = q.Where(p => p.Character_Name.Contains(characterName));
                }

                DateTime registrationTimeFrom = dtpFrom.Value.Date;
                DateTime registrationTimeTo = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
                if (registrationTimeFrom != DateTime.MinValue)
                {
                    q = q.Where(p => p.Registration_Time >= registrationTimeFrom);
                }
                if (registrationTimeTo != DateTime.MaxValue)
                {
                    q = q.Where(p => p.Registration_Time <= registrationTimeTo);
                }

                bindingSourceM.DataSource = q.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //儲存
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int updatedRows = dbContext.SaveChanges();

                // 檢查更新結果
                if (updatedRows > 0)
                {
                    MessageBox.Show("變更已成功儲存至資料庫。");
                }
                else
                {
                    MessageBox.Show("儲存失敗，請檢查您的變更。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
        }

        private void dataGridViewMembers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // 取得發生錯誤的欄位名稱
            string columnName = dataGridViewMembers.Columns[e.ColumnIndex].HeaderText;
            // 自訂錯誤訊息
            string errorMessage = $"欄位 {columnName} 輸入錯誤，請重新輸入正確的資料。";

            // 顯示自訂的訊息框
            MessageBox.Show(errorMessage, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // 取消預設的錯誤訊息框顯示
            e.ThrowException = false;
        }
    }
}
