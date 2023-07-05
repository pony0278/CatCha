namespace FormResize
{
    partial class Frm_BackGroundPack
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.pic_Main = new System.Windows.Forms.PictureBox();
            this.txt_BGTitle = new System.Windows.Forms.Label();
            this.txt_Descibe = new System.Windows.Forms.Label();
            this.txt_Div = new System.Windows.Forms.Label();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.pic_2 = new System.Windows.Forms.PictureBox();
            this.pic_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.Location = new System.Drawing.Point(260, 310);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(79, 28);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Ok.Location = new System.Drawing.Point(120, 310);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(78, 28);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "確認更換";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // pic_Main
            // 
            this.pic_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Main.Location = new System.Drawing.Point(27, 18);
            this.pic_Main.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pic_Main.Name = "pic_Main";
            this.pic_Main.Size = new System.Drawing.Size(169, 108);
            this.pic_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Main.TabIndex = 2;
            this.pic_Main.TabStop = false;
            // 
            // txt_BGTitle
            // 
            this.txt_BGTitle.AutoSize = true;
            this.txt_BGTitle.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_BGTitle.Location = new System.Drawing.Point(202, 28);
            this.txt_BGTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txt_BGTitle.Name = "txt_BGTitle";
            this.txt_BGTitle.Size = new System.Drawing.Size(0, 18);
            this.txt_BGTitle.TabIndex = 3;
            // 
            // txt_Descibe
            // 
            this.txt_Descibe.AutoSize = true;
            this.txt_Descibe.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Descibe.Location = new System.Drawing.Point(198, 73);
            this.txt_Descibe.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txt_Descibe.Name = "txt_Descibe";
            this.txt_Descibe.Size = new System.Drawing.Size(0, 18);
            this.txt_Descibe.TabIndex = 4;
            // 
            // txt_Div
            // 
            this.txt_Div.AutoSize = true;
            this.txt_Div.Location = new System.Drawing.Point(106, 128);
            this.txt_Div.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txt_Div.Name = "txt_Div";
            this.txt_Div.Size = new System.Drawing.Size(245, 12);
            this.txt_Div.TabIndex = 5;
            this.txt_Div.Text = "========================================";
            // 
            // pic_1
            // 
            this.pic_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_1.Image = global::FormResize.Properties.Resources.background_default;
            this.pic_1.Location = new System.Drawing.Point(37, 157);
            this.pic_1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(98, 65);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_1.TabIndex = 6;
            this.pic_1.TabStop = false;
            this.pic_1.Tag = "bg";
            this.pic_1.Click += new System.EventHandler(this.pic_1_Click);
            // 
            // pic_2
            // 
            this.pic_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_2.Image = global::FormResize.Properties.Resources.background_02;
            this.pic_2.Location = new System.Drawing.Point(179, 157);
            this.pic_2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pic_2.Name = "pic_2";
            this.pic_2.Size = new System.Drawing.Size(98, 65);
            this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_2.TabIndex = 7;
            this.pic_2.TabStop = false;
            this.pic_2.Tag = "bg";
            this.pic_2.Click += new System.EventHandler(this.pic_2_Click);
            // 
            // pic_3
            // 
            this.pic_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_3.Image = global::FormResize.Properties.Resources.background_03;
            this.pic_3.Location = new System.Drawing.Point(323, 157);
            this.pic_3.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pic_3.Name = "pic_3";
            this.pic_3.Size = new System.Drawing.Size(98, 65);
            this.pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_3.TabIndex = 8;
            this.pic_3.TabStop = false;
            this.pic_3.Tag = "bg";
            this.pic_3.Click += new System.EventHandler(this.pic_3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(323, 235);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(98, 65);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "bg";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(179, 235);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(98, 65);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "bg";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(37, 235);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(98, 65);
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "bg";
            // 
            // Frm_BackGroundPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(450, 344);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pic_3);
            this.Controls.Add(this.pic_2);
            this.Controls.Add(this.pic_1);
            this.Controls.Add(this.txt_Div);
            this.Controls.Add(this.txt_Descibe);
            this.Controls.Add(this.txt_BGTitle);
            this.Controls.Add(this.pic_Main);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Cancel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Frm_BackGroundPack";
            this.Text = "Frm_BackGroundPack";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.PictureBox pic_Main;
        private System.Windows.Forms.Label txt_BGTitle;
        private System.Windows.Forms.Label txt_Descibe;
        private System.Windows.Forms.Label txt_Div;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.PictureBox pic_2;
        private System.Windows.Forms.PictureBox pic_3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}