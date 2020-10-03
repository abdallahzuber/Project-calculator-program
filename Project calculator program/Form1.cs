using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_calculator_program
{
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        double reslut;

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            reslut = n1 + n2;
            lb_reslut.Text = Convert.ToString(reslut);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            reslut = n1 - n2;
            lb_reslut.Text = Convert.ToString(reslut);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            reslut = n1 * n2;
            lb_reslut.Text = Convert.ToString(reslut);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            reslut = n1 / n2;
            lb_reslut.Text = Convert.ToString(reslut);
        }
    }
}
