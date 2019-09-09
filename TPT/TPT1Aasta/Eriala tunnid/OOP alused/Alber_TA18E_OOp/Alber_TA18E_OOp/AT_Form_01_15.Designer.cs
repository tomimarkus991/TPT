namespace Alber_TA18E_OOp
{
    partial class AT_Form_01_15
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
            this.AT_Timer_1 = new System.Windows.Forms.Timer(this.components);
            this.AT_lbl_Time = new System.Windows.Forms.Label();
            this.AT_btn_Timer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AT_Timer_1
            // 
            this.AT_Timer_1.Enabled = true;
            this.AT_Timer_1.Interval = 1000;
            this.AT_Timer_1.Tick += new System.EventHandler(this.AT_Timer_1_Tick);
            // 
            // AT_lbl_Time
            // 
            this.AT_lbl_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AT_lbl_Time.ForeColor = System.Drawing.Color.Black;
            this.AT_lbl_Time.Location = new System.Drawing.Point(86, 31);
            this.AT_lbl_Time.Name = "AT_lbl_Time";
            this.AT_lbl_Time.Size = new System.Drawing.Size(346, 51);
            this.AT_lbl_Time.TabIndex = 0;
            this.AT_lbl_Time.Click += new System.EventHandler(this.AT_Time_Click);
            // 
            // AT_btn_Timer
            // 
            this.AT_btn_Timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AT_btn_Timer.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AT_btn_Timer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AT_btn_Timer.Location = new System.Drawing.Point(90, 85);
            this.AT_btn_Timer.Name = "AT_btn_Timer";
            this.AT_btn_Timer.Size = new System.Drawing.Size(114, 65);
            this.AT_btn_Timer.TabIndex = 1;
            this.AT_btn_Timer.Text = "Start";
            this.AT_btn_Timer.UseVisualStyleBackColor = false;
            this.AT_btn_Timer.Click += new System.EventHandler(this.AT_btn_Timer_Click);
            // 
            // AT_Form_01_15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 323);
            this.Controls.Add(this.AT_btn_Timer);
            this.Controls.Add(this.AT_lbl_Time);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "AT_Form_01_15";
            this.Text = "AT_Form_01_15";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer AT_Timer_1;
        private System.Windows.Forms.Label AT_lbl_Time;
        private System.Windows.Forms.Button AT_btn_Timer;
    }
}