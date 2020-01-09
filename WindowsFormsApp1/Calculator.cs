using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public int? firstNum = null;
        public int? secondNum = null;
        public int result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void input_one_Click(object sender, EventArgs e)
        {
            area_process.AppendText("1");
            area_result.AppendText("1");
        }

        private void input_two_Click(object sender, EventArgs e)
        {
            area_process.AppendText("2");
            area_result.AppendText("2");
        }

        private void input_thr_Click(object sender, EventArgs e)
        {
            area_process.AppendText("3");
            area_result.AppendText("3");
        }

        private void input_four_Click(object sender, EventArgs e)
        {
            area_process.AppendText("4");
            area_result.AppendText("4");
        }

        private void input_five_Click(object sender, EventArgs e)
        {
            area_process.AppendText("5");
            area_result.AppendText("5");
        }

        private void input_six_Click(object sender, EventArgs e)
        {
            area_process.AppendText("6");
            area_result.AppendText("6");
        }

        private void input_seven_Click(object sender, EventArgs e)
        {
            area_process.AppendText("7");
            area_result.AppendText("7");
        }

        private void input_eight_Click(object sender, EventArgs e)
        {
            area_process.AppendText("8");
            area_result.AppendText("8");
        }

        private void input_nine_Click(object sender, EventArgs e)
        {
            area_process.AppendText("9");
            area_result.AppendText("9");
        }

        private void input_zero_Click(object sender, EventArgs e)
        {
            area_process.AppendText("0");
            area_result.AppendText("0");
        }

        private void input_hundred_Click(object sender, EventArgs e)
        {
            area_process.AppendText("00");
            area_result.AppendText("00");
        }

        private void input_plus_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToInt32(area_process.Text);
            area_process.Clear();
            area_result.AppendText(" + ");
        }
    }
}
