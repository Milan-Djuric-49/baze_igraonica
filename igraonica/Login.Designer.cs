namespace igraonica
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ime = new System.Windows.Forms.Label();
            this.txt_passw = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lozinka";
            // 
            // txt_ime
            // 
            this.txt_ime.AutoSize = true;
            this.txt_ime.Location = new System.Drawing.Point(171, 120);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(35, 13);
            this.txt_ime.TabIndex = 14;
            this.txt_ime.Text = "E-mail";
            // 
            // txt_passw
            // 
            this.txt_passw.Location = new System.Drawing.Point(220, 176);
            this.txt_passw.Name = "txt_passw";
            this.txt_passw.Size = new System.Drawing.Size(180, 20);
            this.txt_passw.TabIndex = 13;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(220, 118);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 20);
            this.txt_name.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_passw);
            this.Controls.Add(this.txt_name);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_ime;
        private System.Windows.Forms.TextBox txt_passw;
        private System.Windows.Forms.TextBox txt_name;
    }
}

