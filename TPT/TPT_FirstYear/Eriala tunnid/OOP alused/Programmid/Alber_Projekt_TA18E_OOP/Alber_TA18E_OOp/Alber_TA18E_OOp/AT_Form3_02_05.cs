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
    public partial class AT_Form3_02_05 : Form
    {
        public AT_Form3_02_05()
        {
            InitializeComponent();
        }

        private void AT_Form3_02_05_Load(object sender, EventArgs e) // MAIN Sellel
        {

        }

        private void AT_btn_lisa_Click(object sender, EventArgs e) // NUPP
        {
            int valitud = AT_list1.SelectedIndex;
            if (valitud < 0)
                AT_list1.Items.Add(AT_txt1.Text); // Vajutusega lisame sisu boxi
            else
                AT_list1.Items.Insert(valitud, AT_txt1.Text);
            AT_list1.SelectedIndex = -1;
            AT_txt1.Text = ""; // Paneb tühja teksti
            AT_txt1.Focus();
        }

        private void AT_Sorted_CheckedChanged(object sender, EventArgs e)
        {
            AT_list1.Sorted = AT_Sorted.Checked;
        }
        
        private void AT_btn_eemalda_Click(object sender, EventArgs e)
        {
            int valitud = AT_list1.SelectedIndex;
            if (valitud < 0)
            {
                MessageBox.Show("Valik puudub");
                return;
            }
            string t = "Kas te soovite seda kustutada:" + (char)(13) + (char)(13) + AT_list1.Items[valitud]; // enteri number on 13
            DialogResult vastus = MessageBox.Show(t, "Achtung, Achtung!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (vastus == DialogResult.Yes)
            {
                AT_list1.Items.RemoveAt(valitud);               
            }
            else
                AT_list1.SelectedIndex = -1;           
        }
        private void AT_list1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AT_btn_uuenda_Click(object sender, EventArgs e)
        {
            //Võtta at_txt1 tekst ja vahetada see välja selected tekstiga
            int valitud = AT_list1.SelectedIndex;
            if (valitud < 0)
            {
                MessageBox.Show("Valik puudub");
                return;
            }

            string t = "Kas te soovite seda uuendada:" + (char)(13) + (char)(13) + AT_list1.Items[valitud]; // enteri number on 13
            DialogResult vastus = MessageBox.Show(t, "Achtung, Achtung!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (vastus == DialogResult.Yes)
            {
                
                AT_list1.Items.Insert(valitud, AT_txt1.Text);
                AT_list1.Items.RemoveAt(valitud + 1);
            }
            
            AT_list1.SelectedIndex = -1;
            AT_txt1.Text = "";
            AT_txt1.Focus();

        }
    }
}
