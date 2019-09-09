namespace Alber_TA18E_OOp
{
    partial class AT_Form_Main
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
            this.AT_btn_01_15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AT_btn_01_15
            // 
            this.AT_btn_01_15.BackColor = System.Drawing.Color.Aqua;
            this.AT_btn_01_15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AT_btn_01_15.Location = new System.Drawing.Point(143, 172);
            this.AT_btn_01_15.Name = "AT_btn_01_15";
            this.AT_btn_01_15.Size = new System.Drawing.Size(135, 301);
            this.AT_btn_01_15.TabIndex = 0;
            this.AT_btn_01_15.Text = "NUPP";
            this.AT_btn_01_15.UseVisualStyleBackColor = false;
            this.AT_btn_01_15.Click += new System.EventHandler(this.AT_btn_01_15_Click);
            // 
            // AT_Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 616);
            this.Controls.Add(this.AT_btn_01_15);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AT_Form_Main";
            this.Text = "AT Main";
            this.Load += new System.EventHandler(this.AT_Form_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AT_btn_01_15;
    }
}

