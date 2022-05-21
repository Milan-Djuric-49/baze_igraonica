namespace igraonica
{
    partial class Korisnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_igraonice = new System.Windows.Forms.ComboBox();
            this.btn_zakazi = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cmb_igraonice
            // 
            this.cmb_igraonice.FormattingEnabled = true;
            this.cmb_igraonice.Location = new System.Drawing.Point(92, 198);
            this.cmb_igraonice.Name = "cmb_igraonice";
            this.cmb_igraonice.Size = new System.Drawing.Size(121, 21);
            this.cmb_igraonice.TabIndex = 1;
            // 
            // btn_zakazi
            // 
            this.btn_zakazi.Location = new System.Drawing.Point(233, 345);
            this.btn_zakazi.Name = "btn_zakazi";
            this.btn_zakazi.Size = new System.Drawing.Size(75, 23);
            this.btn_zakazi.TabIndex = 2;
            this.btn_zakazi.Text = "Zakazi";
            this.btn_zakazi.UseVisualStyleBackColor = true;
            this.btn_zakazi.Click += new System.EventHandler(this.btn_zakazi_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(258, 127);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // Korisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_zakazi);
            this.Controls.Add(this.cmb_igraonice);
            this.Controls.Add(this.label1);
            this.Name = "Korisnik";
            this.Text = "Korisnik";
            this.Load += new System.EventHandler(this.Korisnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_igraonice;
        private System.Windows.Forms.Button btn_zakazi;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}