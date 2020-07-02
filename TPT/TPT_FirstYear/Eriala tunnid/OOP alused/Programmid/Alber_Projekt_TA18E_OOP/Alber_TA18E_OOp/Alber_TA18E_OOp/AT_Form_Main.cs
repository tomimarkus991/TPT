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
    public partial class AT_Form_Main : Form
    {
        Form F1 = new AT_Form_01_15();
        Form F2 = new AT_Form2_01_29();
        Form F3 = new AT_Form3_02_05();
        Form F4 = new AT_Form4_02_19();

        public AT_Form_Main()
        {
            InitializeComponent();
        }

        private void AT_Form_Main_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void AT_btn_01_15_Click(object sender, EventArgs e)
        {
            if (F1.Visible == false) F1 = new AT_Form_01_15();
            F1.Visible = true;
            F1.Activate();
        }

        private void AT_btn_01_29_Click(object sender, EventArgs e)
        {
            if (F2.Visible == false) F2 = new AT_Form2_01_29();
            F2.Visible = true;
            F2.Activate();
        }

        private void AT_btn_02_05_Click(object sender, EventArgs e)
        {
            if (F3.Visible == false) F3 = new AT_Form3_02_05();
            F3.Visible = true;
            F3.Activate();
        }

        private void AT_btn_02_19_Click(object sender, EventArgs e)
        {
            if (F4.Visible == false) F4 = new AT_Form4_02_19();
            F4.Visible = true;
            F4.Activate();
        }
    }
}
