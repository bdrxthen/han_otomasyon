namespace Han
{
    partial class Giris
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
            this.KCikis = new System.Windows.Forms.Button();
            this.KSifre = new System.Windows.Forms.TextBox();
            this.KAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KCikis
            // 
            this.KCikis.Location = new System.Drawing.Point(327, 211);
            this.KCikis.Name = "KCikis";
            this.KCikis.Size = new System.Drawing.Size(100, 25);
            this.KCikis.TabIndex = 15;
            this.KCikis.Text = "Çıkış";
            this.KCikis.UseVisualStyleBackColor = true;
            this.KCikis.Click += new System.EventHandler(this.KCikis_Click);
            // 
            // KSifre
            // 
            this.KSifre.Location = new System.Drawing.Point(289, 172);
            this.KSifre.Name = "KSifre";
            this.KSifre.Size = new System.Drawing.Size(138, 20);
            this.KSifre.TabIndex = 13;
            this.KSifre.UseSystemPasswordChar = true;
            // 
            // KAdi
            // 
            this.KAdi.Location = new System.Drawing.Point(289, 132);
            this.KAdi.Name = "KAdi";
            this.KAdi.Size = new System.Drawing.Size(138, 20);
            this.KAdi.TabIndex = 12;
            this.KAdi.TextChanged += new System.EventHandler(this.KAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(146, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kullanıcı Şifresi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(146, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // KGiris
            // 
            this.KGiris.Location = new System.Drawing.Point(150, 211);
            this.KGiris.Name = "KGiris";
            this.KGiris.Size = new System.Drawing.Size(100, 25);
            this.KGiris.TabIndex = 14;
            this.KGiris.Text = "Giriş";
            this.KGiris.UseVisualStyleBackColor = true;
            this.KGiris.Click += new System.EventHandler(this.KGiris_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.KCikis);
            this.Controls.Add(this.KSifre);
            this.Controls.Add(this.KAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KGiris);
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KCikis;
        private System.Windows.Forms.TextBox KSifre;
        private System.Windows.Forms.TextBox KAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KGiris;
    }
}