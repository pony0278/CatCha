namespace CatChaForms
{
    partial class ForgetPwd
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
            this.ChangeImg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ForgetMsg = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeImg
            // 
            this.ChangeImg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChangeImg.Location = new System.Drawing.Point(567, 202);
            this.ChangeImg.Name = "ChangeImg";
            this.ChangeImg.Size = new System.Drawing.Size(93, 34);
            this.ChangeImg.TabIndex = 35;
            this.ChangeImg.Text = "換別張";
            this.ChangeImg.UseVisualStyleBackColor = true;
            this.ChangeImg.Click += new System.EventHandler(this.ChangeImg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(256, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 34);
            this.textBox1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(425, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 42);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(158, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "驗證碼：";
            // 
            // ForgetMsg
            // 
            this.ForgetMsg.AutoSize = true;
            this.ForgetMsg.ForeColor = System.Drawing.Color.Red;
            this.ForgetMsg.Location = new System.Drawing.Point(317, 255);
            this.ForgetMsg.Name = "ForgetMsg";
            this.ForgetMsg.Size = new System.Drawing.Size(0, 15);
            this.ForgetMsg.TabIndex = 31;
            this.ForgetMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNext.Location = new System.Drawing.Point(189, 283);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(345, 50);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "下一步：修改密碼";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(256, 150);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(261, 34);
            this.txtAccount.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(86, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "帳號(電子郵件)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(247, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 50);
            this.label1.TabIndex = 24;
            this.label1.Text = "忘記密碼";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ForgetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeImg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ForgetMsg);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ForgetPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPwd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeImg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ForgetMsg;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}