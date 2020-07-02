namespace Alber_TA18E_OOp
{
    partial class AT_Form3_02_05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AT_txt1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AT_list1 = new System.Windows.Forms.ListBox();
            this.AT_btn_lisa = new System.Windows.Forms.Button();
            this.AT_btn_eemalda = new System.Windows.Forms.Button();
            this.AT_Sorted = new System.Windows.Forms.CheckBox();
            this.AT_btn_uuenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AT_txt1
            // 
            this.AT_txt1.Location = new System.Drawing.Point(12, 31);
            this.AT_txt1.Multiline = true;
            this.AT_txt1.Name = "AT_txt1";
            this.AT_txt1.Size = new System.Drawing.Size(413, 49);
            this.AT_txt1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AT_list1
            // 
            this.AT_list1.BackColor = System.Drawing.SystemColors.Window;
            this.AT_list1.FormattingEnabled = true;
            this.AT_list1.ItemHeight = 22;
            this.AT_list1.Location = new System.Drawing.Point(12, 86);
            this.AT_list1.Name = "AT_list1";
            this.AT_list1.Size = new System.Drawing.Size(413, 334);
            this.AT_list1.TabIndex = 2;
            this.AT_list1.SelectedIndexChanged += new System.EventHandler(this.AT_list1_SelectedIndexChanged);
            // 
            // AT_btn_lisa
            // 
            this.AT_btn_lisa.Location = new System.Drawing.Point(431, 31);
            this.AT_btn_lisa.Name = "AT_btn_lisa";
            this.AT_btn_lisa.Size = new System.Drawing.Size(113, 54);
            this.AT_btn_lisa.TabIndex = 3;
            this.AT_btn_lisa.Text = "Enter";
            this.AT_btn_lisa.UseVisualStyleBackColor = true;
            this.AT_btn_lisa.Click += new System.EventHandler(this.AT_btn_lisa_Click);
            // 
            // AT_btn_eemalda
            // 
            this.AT_btn_eemalda.BackColor = System.Drawing.Color.Red;
            this.AT_btn_eemalda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AT_btn_eemalda.Location = new System.Drawing.Point(431, 146);
            this.AT_btn_eemalda.Name = "AT_btn_eemalda";
            this.AT_btn_eemalda.Size = new System.Drawing.Size(113, 52);
            this.AT_btn_eemalda.TabIndex = 4;
            this.AT_btn_eemalda.Text = "Remove selected";
            this.AT_btn_eemalda.UseVisualStyleBackColor = false;
            this.AT_btn_eemalda.Click += new System.EventHandler(this.AT_btn_eemalda_Click);
            // 
            // AT_Sorted
            // 
            this.AT_Sorted.BackColor = System.Drawing.Color.Lime;
            this.AT_Sorted.Cursor = System.Windows.Forms.Cursors.Help;
            this.AT_Sorted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AT_Sorted.Location = new System.Drawing.Point(431, 91);
            this.AT_Sorted.Name = "AT_Sorted";
            this.AT_Sorted.Size = new System.Drawing.Size(113, 49);
            this.AT_Sorted.TabIndex = 5;
            this.AT_Sorted.Text = "Sorted";
            this.AT_Sorted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AT_Sorted.UseVisualStyleBackColor = false;
            this.AT_Sorted.CheckedChanged += new System.EventHandler(this.AT_Sorted_CheckedChanged);
            // 
            // AT_btn_uuenda
            // 
            this.AT_btn_uuenda.BackColor = System.Drawing.Color.Aqua;
            this.AT_btn_uuenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AT_btn_uuenda.Location = new System.Drawing.Point(431, 204);
            this.AT_btn_uuenda.Name = "AT_btn_uuenda";
            this.AT_btn_uuenda.Size = new System.Drawing.Size(113, 52);
            this.AT_btn_uuenda.TabIndex = 6;
            this.AT_btn_uuenda.Text = "Uuenda";
            this.AT_btn_uuenda.UseVisualStyleBackColor = false;
            this.AT_btn_uuenda.Click += new System.EventHandler(this.AT_btn_uuenda_Click);
            // 
            // AT_Form3_02_05
            // 
            this.AcceptButton = this.AT_btn_lisa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(647, 478);
            this.Controls.Add(this.AT_btn_uuenda);
            this.Controls.Add(this.AT_Sorted);
            this.Controls.Add(this.AT_btn_eemalda);
            this.Controls.Add(this.AT_btn_lisa);
            this.Controls.Add(this.AT_list1);
            this.Controls.Add(this.AT_txt1);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AT_Form3_02_05";
            this.Text = "AT_Form3_02_05";
            this.Load += new System.EventHandler(this.AT_Form3_02_05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AT_txt1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox AT_list1;
        private System.Windows.Forms.Button AT_btn_lisa;
        private System.Windows.Forms.Button AT_btn_eemalda;
        private System.Windows.Forms.CheckBox AT_Sorted;
        private System.Windows.Forms.Button AT_btn_uuenda;
    }
}