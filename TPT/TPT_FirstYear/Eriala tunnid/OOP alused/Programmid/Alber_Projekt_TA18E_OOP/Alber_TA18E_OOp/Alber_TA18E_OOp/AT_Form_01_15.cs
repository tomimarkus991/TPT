using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Alber_TA18E_OOp
{
    public partial class AT_Form_01_15 : Form
    {
        public AT_Form_01_15()
        {
            InitializeComponent();
        }

        private void AT_Time_Click(object sender, EventArgs e)
        {

        }

        private void AT_Timer_1_Tick(object sender, EventArgs e)
        {
            AT_lbl_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void AT_btn_Timer_Click(object sender, EventArgs e)
        {
            if (AT_Timer_1.Enabled)
            {
                AT_Timer_1.Enabled = false;
                AT_btn_Timer.Text = "Start";
                AT_lbl_Time.Text = "";
            }
            else
            {
                AT_Timer_1.Enabled = true;
                AT_btn_Timer.Text = "Stop";
            }
        }

        private void AT_lbl_Time2_Click(object sender, EventArgs e)
        {

        }

        private void AT_Timer_2_Tick(object sender, EventArgs e)
        {
            AT_lbl_Time2.Text = DateTime.Now.AddHours(-2).ToLongTimeString();
        }

        private void AT_btn_Timer2_Click(object sender, EventArgs e)
        {
            if (AT_Timer_2.Enabled)
            {
                AT_Timer_2.Enabled = false;
                AT_btn_Timer2.Text = "Start";
                AT_lbl_Time2.Text = "";
            }
            else
            {
                AT_Timer_2.Enabled = true;
                AT_btn_Timer2.Text = "Stop";
            }
        }

        private void AT_label3_Click(object sender, EventArgs e)
        {

        }

        private void AT_Timer_3_Tick(object sender, EventArgs e)
        {
            AT_lbl_Time3.Text = DateTime.Now.AddHours(-7).ToLongTimeString();
        }

        private void AT_btn_Timer3_Click(object sender, EventArgs e)
        {
            if (AT_Timer_3.Enabled)
            {
                AT_Timer_3.Enabled = false;
                AT_btn_Timer3.Text = "Start";
                AT_lbl_Time3.Text = "";
            }
            else
            {
                AT_Timer_3.Enabled = true;
                AT_btn_Timer3.Text = "Stop";
            }
        }
    }
}
