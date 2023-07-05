namespace CatChaEntities
{
    partial class Frm00_CMS_Home
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm00_CMS_Home));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelbtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGameMng = new System.Windows.Forms.Button();
            this.btnProductsMng = new System.Windows.Forms.Button();
            this.btnOrdersMng = new System.Windows.Forms.Button();
            this.btnMembersMng = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanelbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelbtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(7);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 585);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanelbtn
            // 
            this.flowLayoutPanelbtn.AutoScroll = true;
            this.flowLayoutPanelbtn.Controls.Add(this.pictureBox1);
            this.flowLayoutPanelbtn.Controls.Add(this.btnGameMng);
            this.flowLayoutPanelbtn.Controls.Add(this.btnProductsMng);
            this.flowLayoutPanelbtn.Controls.Add(this.btnMembersMng);
            this.flowLayoutPanelbtn.Controls.Add(this.btnOrdersMng);
            this.flowLayoutPanelbtn.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelbtn.Name = "flowLayoutPanelbtn";
            this.flowLayoutPanelbtn.Size = new System.Drawing.Size(179, 583);
            this.flowLayoutPanelbtn.TabIndex = 7;
            // 
            // btnGameMng
            // 
            this.btnGameMng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGameMng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGameMng.ForeColor = System.Drawing.Color.Black;
            this.btnGameMng.Location = new System.Drawing.Point(20, 184);
            this.btnGameMng.Margin = new System.Windows.Forms.Padding(20);
            this.btnGameMng.Name = "btnGameMng";
            this.btnGameMng.Size = new System.Drawing.Size(139, 32);
            this.btnGameMng.TabIndex = 1;
            this.btnGameMng.Text = "遊戲管理";
            this.btnGameMng.UseVisualStyleBackColor = true;
            this.btnGameMng.Click += new System.EventHandler(this.btnGameMng_Click);
            // 
            // btnProductsMng
            // 
            this.btnProductsMng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductsMng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductsMng.ForeColor = System.Drawing.Color.Black;
            this.btnProductsMng.Location = new System.Drawing.Point(20, 256);
            this.btnProductsMng.Margin = new System.Windows.Forms.Padding(20);
            this.btnProductsMng.Name = "btnProductsMng";
            this.btnProductsMng.Size = new System.Drawing.Size(139, 32);
            this.btnProductsMng.TabIndex = 4;
            this.btnProductsMng.Text = "商品管理";
            this.btnProductsMng.UseVisualStyleBackColor = true;
            this.btnProductsMng.Click += new System.EventHandler(this.btnProductsMng_Click);
            // 
            // btnOrdersMng
            // 
            this.btnOrdersMng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdersMng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrdersMng.ForeColor = System.Drawing.Color.Black;
            this.btnOrdersMng.Location = new System.Drawing.Point(20, 400);
            this.btnOrdersMng.Margin = new System.Windows.Forms.Padding(20);
            this.btnOrdersMng.Name = "btnOrdersMng";
            this.btnOrdersMng.Size = new System.Drawing.Size(139, 32);
            this.btnOrdersMng.TabIndex = 6;
            this.btnOrdersMng.Text = "訂單管理";
            this.btnOrdersMng.UseVisualStyleBackColor = true;
            this.btnOrdersMng.Click += new System.EventHandler(this.btnOrdersMng_Click);
            // 
            // btnMembersMng
            // 
            this.btnMembersMng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMembersMng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMembersMng.ForeColor = System.Drawing.Color.Black;
            this.btnMembersMng.Location = new System.Drawing.Point(20, 328);
            this.btnMembersMng.Margin = new System.Windows.Forms.Padding(20);
            this.btnMembersMng.Name = "btnMembersMng";
            this.btnMembersMng.Size = new System.Drawing.Size(139, 32);
            this.btnMembersMng.TabIndex = 7;
            this.btnMembersMng.Text = "會員管理";
            this.btnMembersMng.UseVisualStyleBackColor = true;
            this.btnMembersMng.Click += new System.EventHandler(this.btnMembersMng_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(173, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Frm00_CMS_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1061, 585);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Frm00_CMS_Home";
            this.Text = "後台管理系統";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanelbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnProductsMng;
        private System.Windows.Forms.Button btnGameMng;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMembersMng;
        private System.Windows.Forms.Button btnOrdersMng;
    }
}

