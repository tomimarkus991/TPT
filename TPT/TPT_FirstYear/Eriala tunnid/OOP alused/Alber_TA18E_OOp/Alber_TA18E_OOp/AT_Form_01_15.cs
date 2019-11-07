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
    }
}
