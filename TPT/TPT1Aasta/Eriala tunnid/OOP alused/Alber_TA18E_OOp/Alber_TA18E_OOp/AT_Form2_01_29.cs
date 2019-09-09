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
    public partial class AT_Form2_01_29 : Form
    {
        public AT_Form2_01_29()
        {
            InitializeComponent();
        }

        private void AT_lbl_1_Click(object sender, EventArgs e)
        {
            
        }

        private void AT_textBox1_TextChanged(object sender, EventArgs e) // textbox = txt
        {
            if (AT_radioButton1.Checked)
            {
                AT_lbl_1.Text = AT_textBox1.Text;
            }
            else if(AT_radioButton2.Checked)
            {
                string t1 = AT_textBox1.Text;
                string t2 = "";
                for (int i = 0; i < t1.Length; i++)
                {
                    t2 = t1[i] + t2;
                    AT_lbl_1.Text = t2;
                }
            
            }
            else if (AT_radioButton3.Checked)
            {
                string t1 = AT_textBox1.Text;
                string t2 = "";
                for (int i = 0; i < t1.Length; i++)
                {
                    t2 += Char.ToUpper(t1[i]);
                }
                AT_lbl_1.Text = t2;
            }
            else if (AT_radioButton4.Checked)
            {
                string t1 = AT_textBox1.Text;
                string t2 = "";
                for (int i = 0; i < t1.Length; i++)
                {
                    t2 = t2 + t1[i] + " ";
                }
                AT_lbl_1.Text = t2;
            }
            else if (AT_radioButton5.Checked)
            {
                string t1 = AT_textBox1.Text;
                string t2 = "";
                for (int i = 0; i < t1.Length; i++)
                {
                    t2 += Char.ToLower(t1[i]);
                }
                AT_lbl_1.Text = t2;
            }


        }

        private void AT_radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AT_textBox1_TextChanged(null, null);
        }

        private void AT_radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AT_textBox1_TextChanged(null, null);
        }

        private void AT_radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            AT_textBox1_TextChanged(null, null);
        }

        private void AT_radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            AT_textBox1_TextChanged(null, null);
        }

        private void AT_radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            AT_textBox1_TextChanged(null, null);
        }
    }
}
