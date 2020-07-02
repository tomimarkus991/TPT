namespace Alber_TA18E_OOp
{
    partial class AT_Form4_02_19
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
            this.AT_Text1 = new System.Windows.Forms.TextBox();
            this.AT_richText = new System.Windows.Forms.RichTextBox();
            this.AT_label1 = new System.Windows.Forms.Label();
            this.AT_label2 = new System.Windows.Forms.Label();
            this.AT_LoeFail = new System.Windows.Forms.Button();
            this.AT_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AT_label3 = new System.Windows.Forms.Label();
            this.AT_Font = new System.Windows.Forms.Button();
            this.AT_fontDialog1 = new System.Windows.Forms.FontDialog();
            this.AT_Color = new System.Windows.Forms.Button();
            this.AT_colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // AT_Text1
            // 
            this.AT_Text1.Location = new System.Drawing.Point(14, 127);
            this.AT_Text1.Margin = new System.Windows.Forms.Padding(5);
            this.AT_Text1.Multiline = true;
            this.AT_Text1.Name = "AT_Text1";
            this.AT_Text1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AT_Text1.Size = new System.Drawing.Size(755, 246);
            this.AT_Text1.TabIndex = 0;
            // 
            // AT_richText
            // 
            this.AT_richText.Location = new System.Drawing.Point(18, 427);
            this.AT_richText.Margin = new System.Windows.Forms.Padding(5);
            this.AT_richText.Name = "AT_richText";
            this.AT_richText.Size = new System.Drawing.Size(755, 248);
            this.AT_richText.TabIndex = 1;
            this.AT_richText.Text = "";
            // 
            // AT_label1
            // 
            this.AT_label1.AutoSize = true;
            this.AT_label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.AT_label1.Location = new System.Drawing.Point(14, 99);
            this.AT_label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AT_label1.Name = "AT_label1";
            this.AT_label1.Size = new System.Drawing.Size(73, 23);
            this.AT_label1.TabIndex = 2;
            this.AT_label1.Text = "TextBox";
            // 
            // AT_label2
            // 
            this.AT_label2.AutoSize = true;
            this.AT_label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.AT_label2.Location = new System.Drawing.Point(14, 399);
            this.AT_label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AT_label2.Name = "AT_label2";
            this.AT_label2.Size = new System.Drawing.Size(107, 23);
            this.AT_label2.TabIndex = 3;
            this.AT_label2.Text = "RichTextBox";
            // 
            // AT_LoeFail
            // 
            this.AT_LoeFail.BackColor = System.Drawing.Color.Cyan;
            this.AT_LoeFail.Location = new System.Drawing.Point(18, 14);
            this.AT_LoeFail.Margin = new System.Windows.Forms.Padding(5);
            this.AT_LoeFail.Name = "AT_LoeFail";
            this.AT_LoeFail.Size = new System.Drawing.Size(172, 37);
            this.AT_LoeFail.TabIndex = 4;
            this.AT_LoeFail.Text = "Loe faili";
            this.AT_LoeFail.UseVisualStyleBackColor = false;
            this.AT_LoeFail.Click += new System.EventHandler(this.AT_LoeFail_Click);
            // 
            // AT_openFileDialog1
            // 
            this.AT_openFileDialog1.FileName = "openFileDialog1";
            // 
            // AT_label3
            // 
            this.AT_label3.BackColor = System.Drawing.Color.Cyan;
            this.AT_label3.Location = new System.Drawing.Point(14, 56);
            this.AT_label3.Name = "AT_label3";
            this.AT_label3.Size = new System.Drawing.Size(711, 43);
            this.AT_label3.TabIndex = 5;
            // 
            // AT_Font
            // 
            this.AT_Font.BackColor = System.Drawing.Color.Cyan;
            this.AT_Font.Location = new System.Drawing.Point(200, 14);
            this.AT_Font.Margin = new System.Windows.Forms.Padding(5);
            this.AT_Font.Name = "AT_Font";
            this.AT_Font.Size = new System.Drawing.Size(74, 37);
            this.AT_Font.TabIndex = 6;
            this.AT_Font.Text = "Font";
            this.AT_Font.UseVisualStyleBackColor = false;
            this.AT_Font.Click += new System.EventHandler(this.AT_Font_Click);
            // 
            // AT_Color
            // 
            this.AT_Color.BackColor = System.Drawing.Color.Cyan;
            this.AT_Color.Location = new System.Drawing.Point(284, 14);
            this.AT_Color.Margin = new System.Windows.Forms.Padding(5);
            this.AT_Color.Name = "AT_Color";
            this.AT_Color.Size = new System.Drawing.Size(74, 37);
            this.AT_Color.TabIndex = 7;
            this.AT_Color.Text = "Color";
            this.AT_Color.UseVisualStyleBackColor = false;
            this.AT_Color.Click += new System.EventHandler(this.AT_Color_Click);
            // 
            // AT_Form4_02_19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(775, 679);
            this.Controls.Add(this.AT_Color);
            this.Controls.Add(this.AT_Font);
            this.Controls.Add(this.AT_label3);
            this.Controls.Add(this.AT_LoeFail);
            this.Controls.Add(this.AT_label2);
            this.Controls.Add(this.AT_label1);
            this.Controls.Add(this.AT_richText);
            this.Controls.Add(this.AT_Text1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AT_Form4_02_19";
            this.Text = "AT_Form4_02_19";
            this.Load += new System.EventHandler(this.AT_Form4_02_19_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AT_Text1;
        private System.Windows.Forms.RichTextBox AT_richText;
        private System.Windows.Forms.Label AT_label1;
        private System.Windows.Forms.Label AT_label2;
        private System.Windows.Forms.Button AT_LoeFail;
        private System.Windows.Forms.OpenFileDialog AT_openFileDialog1;
        private System.Windows.Forms.Label AT_label3;
        private System.Windows.Forms.Button AT_Font;
        private System.Windows.Forms.FontDialog AT_fontDialog1;
        private System.Windows.Forms.Button AT_Color;
        private System.Windows.Forms.ColorDialog AT_colorDialog1;
    }
}