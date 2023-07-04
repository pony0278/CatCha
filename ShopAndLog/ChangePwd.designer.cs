namespace CatChaForms
{
    partial class ChangePwd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changepassword = new System.Windows.Forms.Button();
            this.newCheckPwd = new System.Windows.Forms.TextBox();
            this.newPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(297, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(279, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 50);
            this.label3.TabIndex = 26;
            this.label3.Text = "重設密碼";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // changepassword
            // 
            this.changepassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changepassword.Location = new System.Drawing.Point(273, 282);
            this.changepassword.Name = "changepassword";
            this.changepassword.Size = new System.Drawing.Size(238, 46);
            this.changepassword.TabIndex = 25;
            this.changepassword.Text = "確定修改";
            this.changepassword.UseVisualStyleBackColor = true;
            this.changepassword.Click += new System.EventHandler(this.changepassword_Click);
            // 
            // newCheckPwd
            // 
            this.newCheckPwd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.newCheckPwd.Location = new System.Drawing.Point(273, 207);
            this.newCheckPwd.Name = "newCheckPwd";
            this.newCheckPwd.Size = new System.Drawing.Size(238, 34);
            this.newCheckPwd.TabIndex = 24;
            this.newCheckPwd.TextChanged += new System.EventHandler(this.newCheckPwd_TextChanged);
            // 
            // newPwd
            // 
            this.newPwd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.newPwd.Location = new System.Drawing.Point(273, 147);
            this.newPwd.Name = "newPwd";
            this.newPwd.Size = new System.Drawing.Size(238, 34);
            this.newPwd.TabIndex = 23;
            this.newPwd.TextChanged += new System.EventHandler(this.newPwd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(135, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "確認新密碼：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(175, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "新密碼：";
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changepassword);
            this.Controls.Add(this.newCheckPwd);
            this.Controls.Add(this.newPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePwd";
            this.Load += new System.EventHandler(this.ChangePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changepassword;
        private System.Windows.Forms.TextBox newCheckPwd;
        private System.Windows.Forms.TextBox newPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}