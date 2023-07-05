namespace CatCha
{
    partial class UserToolStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserToolStrip));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbtnGoToShop = new System.Windows.Forms.ToolStripButton();
            this.tbtnGoToGame = new System.Windows.Forms.ToolStripButton();
            this.tbtnBlog = new System.Windows.Forms.ToolStripButton();
            this.tbtnCustomerService = new System.Windows.Forms.ToolStripButton();
            this.tbtnMember = new System.Windows.Forms.ToolStripButton();
            this.tbtnGoToCart = new System.Windows.Forms.ToolStripButton();
            this.tbtnGoToLike = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnGoToShop,
            this.tbtnGoToGame,
            this.tbtnBlog,
            this.tbtnCustomerService,
            this.tbtnMember,
            this.tbtnGoToCart,
            this.tbtnGoToLike});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(1230, 39);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tbtnGoToShop
            // 
            this.tbtnGoToShop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbtnGoToShop.Image = ((System.Drawing.Image)(resources.GetObject("tbtnGoToShop.Image")));
            this.tbtnGoToShop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnGoToShop.Margin = new System.Windows.Forms.Padding(10, 1, 40, 2);
            this.tbtnGoToShop.Name = "tbtnGoToShop";
            this.tbtnGoToShop.Size = new System.Drawing.Size(128, 36);
            this.tbtnGoToShop.Text = "商城首頁";
            this.tbtnGoToShop.Click += new System.EventHandler(this.tbtnGoToShop_Click);
            // 
            // tbtnGoToGame
            // 
            this.tbtnGoToGame.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbtnGoToGame.Image = ((System.Drawing.Image)(resources.GetObject("tbtnGoToGame.Image")));
            this.tbtnGoToGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnGoToGame.Margin = new System.Windows.Forms.Padding(0, 1, 40, 2);
            this.tbtnGoToGame.Name = "tbtnGoToGame";
            this.tbtnGoToGame.Size = new System.Drawing.Size(128, 36);
            this.tbtnGoToGame.Text = "遊戲首頁";
            // 
            // tbtnBlog
            // 
            this.tbtnBlog.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbtnBlog.Image = ((System.Drawing.Image)(resources.GetObject("tbtnBlog.Image")));
            this.tbtnBlog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnBlog.Margin = new System.Windows.Forms.Padding(0, 1, 40, 2);
            this.tbtnBlog.Name = "tbtnBlog";
            this.tbtnBlog.Size = new System.Drawing.Size(108, 36);
            this.tbtnBlog.Text = "部落格";
            // 
            // tbtnCustomerService
            // 
            this.tbtnCustomerService.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnCustomerService.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbtnCustomerService.Image = ((System.Drawing.Image)(resources.GetObject("tbtnCustomerService.Image")));
            this.tbtnCustomerService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCustomerService.Margin = new System.Windows.Forms.Padding(10, 1, 40, 2);
            this.tbtnCustomerService.Name = "tbtnCustomerService";
            this.tbtnCustomerService.Size = new System.Drawing.Size(128, 36);
            this.tbtnCustomerService.Text = "客服中心";
            // 
            // tbtnMember
            // 
            this.tbtnMember.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbtnMember.Image = ((System.Drawing.Image)(resources.GetObject("tbtnMember.Image")));
            this.tbtnMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMember.Margin = new System.Windows.Forms.Padding(0, 1, 40, 2);
            this.tbtnMember.Name = "tbtnMember";
            this.tbtnMember.Size = new System.Drawing.Size(128, 36);
            this.tbtnMember.Text = "會員中心";
            this.tbtnMember.Click += new System.EventHandler(this.tbtnMember_Click);
            // 
            // tbtnGoToCart
            // 
            this.tbtnGoToCart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnGoToCart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbtnGoToCart.Image = ((System.Drawing.Image)(resources.GetObject("tbtnGoToCart.Image")));
            this.tbtnGoToCart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnGoToCart.Margin = new System.Windows.Forms.Padding(0, 1, 40, 2);
            this.tbtnGoToCart.Name = "tbtnGoToCart";
            this.tbtnGoToCart.Size = new System.Drawing.Size(108, 36);
            this.tbtnGoToCart.Text = "購物車";
            this.tbtnGoToCart.Click += new System.EventHandler(this.tbtnGoToCart_Click);
            // 
            // tbtnGoToLike
            // 
            this.tbtnGoToLike.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnGoToLike.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbtnGoToLike.Image = ((System.Drawing.Image)(resources.GetObject("tbtnGoToLike.Image")));
            this.tbtnGoToLike.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnGoToLike.Margin = new System.Windows.Forms.Padding(0, 1, 40, 2);
            this.tbtnGoToLike.Name = "tbtnGoToLike";
            this.tbtnGoToLike.Size = new System.Drawing.Size(128, 36);
            this.tbtnGoToLike.Text = "收藏清單";
            // 
            // UserToolStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserToolStrip";
            this.Size = new System.Drawing.Size(1230, 49);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbtnGoToShop;
        private System.Windows.Forms.ToolStripButton tbtnGoToGame;
        private System.Windows.Forms.ToolStripButton tbtnBlog;
        private System.Windows.Forms.ToolStripButton tbtnCustomerService;
        private System.Windows.Forms.ToolStripButton tbtnMember;
        private System.Windows.Forms.ToolStripButton tbtnGoToCart;
        private System.Windows.Forms.ToolStripButton tbtnGoToLike;
    }
}
