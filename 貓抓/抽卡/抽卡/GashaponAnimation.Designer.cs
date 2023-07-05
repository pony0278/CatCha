namespace 抽卡
{
    partial class GashaponAnimation
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
            this.Single_LabPirzeName = new System.Windows.Forms.Label();
            this.SinglePicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SinglePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Single_LabPirzeName
            // 
            this.Single_LabPirzeName.AutoSize = true;
            this.Single_LabPirzeName.BackColor = System.Drawing.Color.Transparent;
            this.Single_LabPirzeName.Location = new System.Drawing.Point(364, 160);
            this.Single_LabPirzeName.Name = "Single_LabPirzeName";
            this.Single_LabPirzeName.Size = new System.Drawing.Size(39, 12);
            this.Single_LabPirzeName.TabIndex = 45;
            this.Single_LabPirzeName.Text = "label16";
            // 
            // SinglePicturebox
            // 
            this.SinglePicturebox.BackColor = System.Drawing.Color.Transparent;
            this.SinglePicturebox.Location = new System.Drawing.Point(341, 175);
            this.SinglePicturebox.Name = "SinglePicturebox";
            this.SinglePicturebox.Size = new System.Drawing.Size(118, 115);
            this.SinglePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SinglePicturebox.TabIndex = 44;
            this.SinglePicturebox.TabStop = false;
            // 
            // GashaponAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Single_LabPirzeName);
            this.Controls.Add(this.SinglePicturebox);
            this.Name = "GashaponAnimation";
            this.Text = "GashaponAnimation";
            ((System.ComponentModel.ISupportInitialize)(this.SinglePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Single_LabPirzeName;
        private System.Windows.Forms.PictureBox SinglePicturebox;
    }
}