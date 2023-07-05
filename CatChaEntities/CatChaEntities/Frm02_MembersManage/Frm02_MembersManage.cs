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
            LoadData();
            //初始化DateTimePicker
            dtpFrom.Value = new DateTime(2000, 1, 1);
            dtpTo.Value = DateTime.Today;
        }

        //載入DataBase
        void LoadData()
        {
            //LoadData
            var members = dbContext.Shop_Member_Info.ToList();
            this.bindingSourceM.DataSource = members;
            dataGridViewMembers.DataSource = bindingSourceM;
        }

        //搜尋按鈕
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


        //儲存按鈕
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newMember = bindingSourceM.DataSource as List<Shop_Member_Info>;
                if (newMember != null)
                {
                    foreach (var member in newMember)
                    {
                        if (member.Member_ID == 0)
                        {
                            dbContext.Shop_Member_Info.Add(member);
                        }
                    }
                }

                int updatedRows = dbContext.SaveChanges();

                // 檢查更新結果
                if (updatedRows > 0)
                {
                    MessageBox.Show("變更已成功儲存至資料庫。");
                    LoadData();
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

        //設定DataGridView編輯時產生的DataError訊息方塊
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

        //dataGridViewGameProducts的右鍵刪除功能
        private void ToolStripDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembers.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewMembers.SelectedRows[0];
                    if (selectedRow.Cells["Member_ID"].Value != null)
                    {
                        int memberID = (int)selectedRow.Cells["Member_ID"].Value;
                        Shop_Member_Info membeToDelete = dbContext.Shop_Member_Info.Find(memberID);

                        DialogResult result = MessageBox.Show("確定要刪除選取的資料行嗎？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            dbContext.Shop_Member_Info.Remove(membeToDelete);
                            int deletedRows = dbContext.SaveChanges();

                            if (deletedRows > 0)
                            {
                                MessageBox.Show("資料行已成功刪除。");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("刪除失敗，請檢查您的操作。");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("選取的資料行無效，請重新選取。");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("發生錯誤: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("請先選取要刪除的資料行。");
            }
        }
    }
}
