
namespace sifreleme_islemleri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sifrele = new System.Windows.Forms.Button();
            this.algoSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifrelenecekMetin = new System.Windows.Forms.TextBox();
            this.sifreliMetin = new System.Windows.Forms.Label();
            this.algoMetin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifrele
            // 
            this.sifrele.Location = new System.Drawing.Point(58, 258);
            this.sifrele.Name = "sifrele";
            this.sifrele.Size = new System.Drawing.Size(94, 29);
            this.sifrele.TabIndex = 0;
            this.sifrele.Text = "ŞİFRELE";
            this.sifrele.UseVisualStyleBackColor = true;
            this.sifrele.Click += new System.EventHandler(this.sifrele_Click);
            // 
            // algoSec
            // 
            this.algoSec.FormattingEnabled = true;
            this.algoSec.Items.AddRange(new object[] {
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "MD5"});
            this.algoSec.Location = new System.Drawing.Point(328, 200);
            this.algoSec.Name = "algoSec";
            this.algoSec.Size = new System.Drawing.Size(151, 28);
            this.algoSec.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ŞİFRELEME ALGORİTMA TÜRÜ:";
            // 
            // sifrelenecekMetin
            // 
            this.sifrelenecekMetin.Location = new System.Drawing.Point(58, 77);
            this.sifrelenecekMetin.Multiline = true;
            this.sifrelenecekMetin.Name = "sifrelenecekMetin";
            this.sifrelenecekMetin.Size = new System.Drawing.Size(421, 111);
            this.sifrelenecekMetin.TabIndex = 3;
            // 
            // sifreliMetin
            // 
            this.sifreliMetin.Location = new System.Drawing.Point(12, 331);
            this.sifreliMetin.Name = "sifreliMetin";
            this.sifreliMetin.Size = new System.Drawing.Size(498, 183);
            this.sifreliMetin.TabIndex = 4;
            this.sifreliMetin.Text = "şifreli metin";
            this.sifreliMetin.Visible = false;
            // 
            // algoMetin
            // 
            this.algoMetin.AutoSize = true;
            this.algoMetin.Location = new System.Drawing.Point(58, 311);
            this.algoMetin.Name = "algoMetin";
            this.algoMetin.Size = new System.Drawing.Size(67, 20);
            this.algoMetin.TabIndex = 5;
            this.algoMetin.Text = "şifre türü";
            this.algoMetin.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ŞİFRELENECEK METİN:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.algoMetin);
            this.Controls.Add(this.sifreliMetin);
            this.Controls.Add(this.sifrelenecekMetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.algoSec);
            this.Controls.Add(this.sifrele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sifrele;
        private System.Windows.Forms.ComboBox algoSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifrelenecekMetin;
        private System.Windows.Forms.Label algoMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sifreliMetin;
    }
}

