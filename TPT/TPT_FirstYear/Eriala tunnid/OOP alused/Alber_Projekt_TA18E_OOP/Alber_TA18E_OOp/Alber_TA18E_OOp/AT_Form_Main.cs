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
    }
}
