using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs
{
    public partial class PersonalAchievement : Form
    {
        public PersonalAchievement()
        {
            InitializeComponent();

            Bitmap bit = new Bitmap("eQc4d3.gif");
            this.pictureBox1.Image = bit;
        }
    }
}
