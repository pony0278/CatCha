namespace FormResize
{
    partial class Frm_CatMove
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
            this.timer_CatWalk = new System.Windows.Forms.Timer(this.components);
            this.pic_Cat1 = new System.Windows.Forms.PictureBox();
            this.timer_CatStop = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            //((System.ComponentModel.ISupportInitialize)(this.pic_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cat1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Back
            // 
            //this.pic_Back.Size = new System.Drawing.Size(764, 481);
            // 
            // timer_CatWalk
            // 
            this.timer_CatWalk.Interval = 1000;
            this.timer_CatWalk.Tick += new System.EventHandler(this.timer_CatWalk_Tick);
            // 
            // pic_Cat1
            // 
            this.pic_Cat1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Cat1.BackColor = System.Drawing.Color.Transparent;
            this.pic_Cat1.Font = new System.Drawing.Font("新細明體", 5.286006F);
            this.pic_Cat1.Image = global::FormResize.Properties.Resources.cat1_walkR;
            this.pic_Cat1.Location = new System.Drawing.Point(147, 225);
            this.pic_Cat1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.pic_Cat1.Name = "pic_Cat1";
            this.pic_Cat1.Size = new System.Drawing.Size(113, 117);
            this.pic_Cat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Cat1.TabIndex = 0;
            this.pic_Cat1.TabStop = false;
            this.pic_Cat1.Tag = "200;200;518;42;9";
            // 
            // timer_CatStop
            // 
            this.timer_CatStop.Tick += new System.EventHandler(this.timer_CatStop_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 76);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_CatMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_Cat1);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.MinimumSize = new System.Drawing.Size(720, 450);
            this.Name = "Frm_CatMove";
            this.Text = "Frm_CatMove";
            this.Load += new System.EventHandler(this.Frm_CatMove_Load);
            //this.Controls.SetChildIndex(this.pic_Back, 0);
            this.Controls.SetChildIndex(this.pic_Cat1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            //((System.ComponentModel.ISupportInitialize)(this.pic_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cat1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_CatWalk;
        private System.Windows.Forms.PictureBox pic_Cat1;
        private System.Windows.Forms.Timer timer_CatStop;
        private System.Windows.Forms.Button button1;
    }
}