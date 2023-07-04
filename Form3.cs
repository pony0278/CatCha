using CatCaha.CallDataToForm;
using CatCaha.IcaptureData;
using CatCaha.ProductsList;
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
    public partial class Form3 : Form
    {
        CallDataToForm.CallDataToForm callTeacherData = new CallDataToForm.CallDataToForm();
        public Form3()
        {
            InitializeComponent();
            button1.Tag = "GetAll";
            button2.Tag = "OverThan20";
            callTeacherData.ShowUserData(this);
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            
            callTeacherData.ShowProducts(this, flowLayoutPanel1, button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            callTeacherData.ShowProducts(this, flowLayoutPanel1,button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            callTeacherData.ShowProducts(this, flowLayoutPanel1, button2);
        }

        public void SetLabel1(int label)
        {
            this.label1.Text = label.ToString();
        }
        public void SetLabel2(int label)
        {
            label2.Text = label.ToString();
        }

    }
}
