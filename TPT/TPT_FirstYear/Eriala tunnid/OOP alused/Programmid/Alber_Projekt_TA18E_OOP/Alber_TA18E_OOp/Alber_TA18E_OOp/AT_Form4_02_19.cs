using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Alber_TA18E_OOp
{
    public partial class AT_Form4_02_19 : Form
    {
        public AT_Form4_02_19()
        {
            InitializeComponent();
        }

        private void AT_Form4_02_19_Load(object sender, EventArgs e)
        {

        }

        private void AT_LoeFail_Click(object sender, EventArgs e)
        {
            AT_openFileDialog1.Filter = "Tekstifailid|*.txt;*.log;*.cs|RTF failid|*.RTF|Suvalised|*.*";
            AT_openFileDialog1.FileName = ""; // Kustutab eelmise teksti ära kui on
            AT_openFileDialog1.ShowDialog();
            string failinimi = AT_openFileDialog1.FileName;
             AT_label3.Text = failinimi;
            if (failinimi == "") return;
            {
                string laiend = failinimi.Substring(failinimi.Length-4).ToLower();
                if(laiend == ".rtf")
                {
                    AT_richText.Rtf = System.IO.File.ReadAllText(failinimi);
                    AT_Text1.Text = AT_richText.Text;
                }
                else
                {
                    AT_Text1.Text = System.IO.File.ReadAllText(failinimi);                   
                    AT_richText.Text = AT_Text1.Text;
                }              
            }
        }

       

        private void AT_Font_Click(object sender, EventArgs e)
        {
            if (AT_richText.SelectionLength > 0)
            {
                AT_fontDialog1.Font = AT_richText.SelectionFont;
                DialogResult v = AT_fontDialog1.ShowDialog();
                if (v == DialogResult.OK)
                { 
                    AT_richText.SelectionFont = AT_fontDialog1.Font;
                }
            }

            else
            {
                AT_richText.SelectionStart = 0;
                AT_richText.SelectionLength = 1;
                DialogResult v = AT_fontDialog1.ShowDialog();
                if (v == DialogResult.OK)
                {
                    AT_richText.SelectAll();
                    AT_richText.SelectionFont = AT_fontDialog1.Font;
                }
                             
            }
            AT_richText.SelectionStart = 0;
            AT_richText.SelectionLength = 0;
        }

        private void AT_Color_Click(object sender, EventArgs e)
        {
            AT_colorDialog1.ShowDialog();
            if (AT_richText.SelectionLength > 0)
            {
                AT_richText.SelectionColor = AT_colorDialog1.Color;                             
            }
            else
            {
                AT_richText.ForeColor = AT_colorDialog1.Color;
            }
            AT_richText.SelectionStart = 0;
            AT_richText.SelectionLength = 0;


        }
    }
}
