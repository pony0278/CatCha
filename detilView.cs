using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha
{
    public partial class detilView : Form
    {
        public detilView()
        {
            InitializeComponent();
        }

        public void SetImage(Image image)
        {
            this.pictureBox1.Image = image;
        }

        public void SetLabel1Text(int text)
        {
            this.label1.Text = text.ToString();
        }
        public void SetLabe2Text(string text)
        {
            this.label2.Text = text;
        }
    }
}
