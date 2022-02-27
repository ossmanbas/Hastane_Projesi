
namespace Hastane_Projesi
{
    partial class HastaKayit
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
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.radioKadin = new System.Windows.Forms.RadioButton();
            this.btnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(160, 170);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(92, 23);
            this.txtSifre.TabIndex = 8;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(161, 91);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(91, 23);
            this.mskTC.TabIndex = 7;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(86, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "TC Kimlik No :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(161, 49);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(91, 23);
            this.txtSoyad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soyad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(161, 9);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(91, 23);
            this.txtAd.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ad :";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(161, 129);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(91, 23);
            this.mskTel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(54, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cinsiyet :";
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.Location = new System.Drawing.Point(160, 212);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(53, 19);
            this.radioErkek.TabIndex = 16;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            // 
            // radioKadin
            // 
            this.radioKadin.AutoSize = true;
            this.radioKadin.Location = new System.Drawing.Point(209, 212);
            this.radioKadin.Name = "radioKadin";
            this.radioKadin.Size = new System.Drawing.Size(55, 19);
            this.radioKadin.TabIndex = 17;
            this.radioKadin.TabStop = true;
            this.radioKadin.Text = "Kadın";
            this.radioKadin.UseVisualStyleBackColor = true;
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnKayit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKayit.Location = new System.Drawing.Point(105, 241);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(108, 41);
            this.btnKayit.TabIndex = 18;
            this.btnKayit.Text = "KAYIT YAP";
            this.btnKayit.UseVisualStyleBackColor = false;
            // 
            // HastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(322, 290);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.radioKadin);
            this.Controls.Add(this.radioErkek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "HastaKayit";
            this.Text = "HastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioErkek;
        private System.Windows.Forms.RadioButton radioKadin;
        private System.Windows.Forms.Button btnKayit;
    }
}