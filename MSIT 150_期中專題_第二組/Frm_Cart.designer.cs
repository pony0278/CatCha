using System;

namespace CatCha
{
    partial class Frm_Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cart));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.labBonus = new System.Windows.Forms.Label();
            this.labTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGoShop = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.userToolStrip1 = new CatCha.UserToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1608, 1055);
            this.splitContainer1.SplitterDistance = 913;
            this.splitContainer1.TabIndex = 20;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            //this.splitContainer2.Panel1.Controls.Add(this.userToolStrip1);
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanelProducts);
            this.splitContainer2.Panel1.Controls.Add(this.labBonus);
            this.splitContainer2.Panel1.Controls.Add(this.labTotalAmount);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnGoShop);
            this.splitContainer2.Panel2.Controls.Add(this.btnCheckOut);
            this.splitContainer2.Size = new System.Drawing.Size(1608, 913);
            this.splitContainer2.SplitterDistance = 752;
            this.splitContainer2.TabIndex = 9;
            this.splitContainer2.TabStop = false;
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanelProducts.AutoScroll = true;
            this.flowLayoutPanelProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(142, 205);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(1411, 449);
            this.flowLayoutPanelProducts.TabIndex = 7;
            // 
            // labBonus
            // 
            this.labBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labBonus.AutoSize = true;
            this.labBonus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBonus.Location = new System.Drawing.Point(920, 679);
            this.labBonus.Name = "labBonus";
            this.labBonus.Size = new System.Drawing.Size(166, 34);
            this.labBonus.TabIndex = 19;
            this.labBonus.Text = "可獲得0紅利";
            // 
            // labTotalAmount
            // 
            this.labTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labTotalAmount.AutoSize = true;
            this.labTotalAmount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalAmount.Location = new System.Drawing.Point(1148, 676);
            this.labTotalAmount.Name = "labTotalAmount";
            this.labTotalAmount.Size = new System.Drawing.Size(34, 38);
            this.labTotalAmount.TabIndex = 17;
            this.labTotalAmount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "購物車清單";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(201, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1280, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnGoShop
            // 
            this.btnGoShop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGoShop.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGoShop.Location = new System.Drawing.Point(628, 47);
            this.btnGoShop.Name = "btnGoShop";
            this.btnGoShop.Size = new System.Drawing.Size(140, 54);
            this.btnGoShop.TabIndex = 20;
            this.btnGoShop.Text = "回商城再逛逛";
            this.btnGoShop.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCheckOut.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckOut.Location = new System.Drawing.Point(841, 47);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(140, 54);
            this.btnCheckOut.TabIndex = 21;
            this.btnCheckOut.Text = "去結帳";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(523, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 62);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(5, 25);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(3, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(556, 22);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "合作洽談：CatchaShop@gmail.com";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(556, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "※貓抓股份有限公司版權所有";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(3, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(556, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Copyright © 2020 All rights reserved";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userToolStrip1
            // 
            this.userToolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.userToolStrip1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.userToolStrip1.Name = "userToolStrip1";
            this.userToolStrip1.Size = new System.Drawing.Size(1608, 49);
            this.userToolStrip1.TabIndex = 20;
            // 
            // Frm_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1608, 1055);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Cart";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Cart_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGoShop;
        private System.Windows.Forms.Label labBonus;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label labTotalAmount;
        private UserToolStrip userToolStrip1;
    }
}

