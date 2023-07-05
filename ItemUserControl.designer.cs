namespace CatCha
{
    partial class ItemUserControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemUserControl));
            this.picBoxItem = new System.Windows.Forms.PictureBox();
            this.labItemName = new System.Windows.Forms.Label();
            this.labItemPrice = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labNT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxItem
            // 
            this.picBoxItem.Image = ((System.Drawing.Image)(resources.GetObject("picBoxItem.Image")));
            this.picBoxItem.Location = new System.Drawing.Point(18, 27);
            this.picBoxItem.Name = "picBoxItem";
            this.picBoxItem.Size = new System.Drawing.Size(106, 108);
            this.picBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxItem.TabIndex = 0;
            this.picBoxItem.TabStop = false;
            // 
            // labItemName
            // 
            this.labItemName.AutoSize = true;
            this.labItemName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labItemName.Location = new System.Drawing.Point(134, 71);
            this.labItemName.Name = "labItemName";
            this.labItemName.Size = new System.Drawing.Size(170, 21);
            this.labItemName.TabIndex = 1;
            this.labItemName.Text = "喵洽普｜貓咪營養肉泥";
            // 
            // labItemPrice
            // 
            this.labItemPrice.AutoSize = true;
            this.labItemPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labItemPrice.Location = new System.Drawing.Point(378, 70);
            this.labItemPrice.Name = "labItemPrice";
            this.labItemPrice.Size = new System.Drawing.Size(30, 21);
            this.labItemPrice.TabIndex = 2;
            this.labItemPrice.Text = "65";
            // 
            // labCount
            // 
            this.labCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCount.Location = new System.Drawing.Point(519, 74);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(26, 21);
            this.labCount.TabIndex = 3;
            this.labCount.Text = "1";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(543, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubtract.Location = new System.Drawing.Point(477, 62);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(34, 36);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.Location = new System.Drawing.Point(670, 70);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(30, 21);
            this.labTotalPrice.TabIndex = 6;
            this.labTotalPrice.Text = "65";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(740, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 41);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labNT
            // 
            this.labNT.AutoSize = true;
            this.labNT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNT.Location = new System.Drawing.Point(351, 70);
            this.labNT.Name = "labNT";
            this.labNT.Size = new System.Drawing.Size(32, 21);
            this.labNT.TabIndex = 8;
            this.labNT.Text = "NT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(643, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "NT";
            // 
            // ItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labNT);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.labItemPrice);
            this.Controls.Add(this.labItemName);
            this.Controls.Add(this.picBoxItem);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemUserControl";
            this.Size = new System.Drawing.Size(996, 162);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxItem;
        private System.Windows.Forms.Label labItemName;
        private System.Windows.Forms.Label labItemPrice;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labNT;
        private System.Windows.Forms.Label label1;
    }
}
