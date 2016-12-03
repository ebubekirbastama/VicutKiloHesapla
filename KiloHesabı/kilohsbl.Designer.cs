namespace KiloHesabı
{
    partial class kilohsbl
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txt_kilo = new MetroFramework.Controls.MetroTextBox();
            this.txt_boy = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(54, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Yazılım Eğitim Kanalı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(132, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(67, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kilo:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(394, 49);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(194, 164);
            this.webBrowser1.TabIndex = 16;
            this.webBrowser1.Url = new System.Uri("http://www.ebubekirbastama.com", System.UriKind.Absolute);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(72, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Boy:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(102, 199);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 40);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Vücut kitle endeksi \r\nhesapla";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txt_kilo
            // 
            this.txt_kilo.ForeColor = System.Drawing.Color.Red;
            this.txt_kilo.Lines = new string[0];
            this.txt_kilo.Location = new System.Drawing.Point(113, 116);
            this.txt_kilo.MaxLength = 32767;
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.PasswordChar = '\0';
            this.txt_kilo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_kilo.SelectedText = "";
            this.txt_kilo.Size = new System.Drawing.Size(108, 19);
            this.txt_kilo.TabIndex = 2;
            this.txt_kilo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_kilo.UseSelectable = true;
            // 
            // txt_boy
            // 
            this.txt_boy.ForeColor = System.Drawing.Color.Red;
            this.txt_boy.Lines = new string[0];
            this.txt_boy.Location = new System.Drawing.Point(113, 86);
            this.txt_boy.MaxLength = 32767;
            this.txt_boy.Name = "txt_boy";
            this.txt_boy.PasswordChar = '\0';
            this.txt_boy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_boy.SelectedText = "";
            this.txt_boy.Size = new System.Drawing.Size(108, 19);
            this.txt_boy.TabIndex = 1;
            this.txt_boy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_boy.UseSelectable = true;
            // 
            // kilohsbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 262);
            this.Controls.Add(this.txt_boy);
            this.Controls.Add(this.txt_kilo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton1);
            this.Name = "kilohsbl";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.kilohsbl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txt_boy;
        private MetroFramework.Controls.MetroTextBox txt_kilo;
    }
}