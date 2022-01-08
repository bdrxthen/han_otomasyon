namespace Han
{
    partial class VeriDepo
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
            this.Firma_Arama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVeri = new System.Windows.Forms.Button();
            this.Firma_Arama_DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btngeri = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Firma_Arama_DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Firma_Arama
            // 
            this.Firma_Arama.Location = new System.Drawing.Point(109, 264);
            this.Firma_Arama.Name = "Firma_Arama";
            this.Firma_Arama.Size = new System.Drawing.Size(100, 20);
            this.Firma_Arama.TabIndex = 20;
            this.Firma_Arama.TextChanged += new System.EventHandler(this.Firma_Arama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Aranacak Firma";
            // 
            // BtnVeri
            // 
            this.BtnVeri.Location = new System.Drawing.Point(452, 256);
            this.BtnVeri.Name = "BtnVeri";
            this.BtnVeri.Size = new System.Drawing.Size(120, 25);
            this.BtnVeri.TabIndex = 18;
            this.BtnVeri.Text = "Tüm Verileri Göster";
            this.BtnVeri.UseVisualStyleBackColor = true;
            this.BtnVeri.Click += new System.EventHandler(this.BtnVeri_Click);
            // 
            // Firma_Arama_DataGridView1
            // 
            this.Firma_Arama_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Firma_Arama_DataGridView1.Location = new System.Drawing.Point(12, 12);
            this.Firma_Arama_DataGridView1.Name = "Firma_Arama_DataGridView1";
            this.Firma_Arama_DataGridView1.Size = new System.Drawing.Size(560, 218);
            this.Firma_Arama_DataGridView1.TabIndex = 17;
            // 
            // Btngeri
            // 
            this.Btngeri.Location = new System.Drawing.Point(12, 324);
            this.Btngeri.Name = "Btngeri";
            this.Btngeri.Size = new System.Drawing.Size(100, 25);
            this.Btngeri.TabIndex = 16;
            this.Btngeri.Text = "Geri";
            this.Btngeri.UseVisualStyleBackColor = true;
            this.Btngeri.Click += new System.EventHandler(this.Btngeri_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(472, 324);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(100, 25);
            this.BtnCikis.TabIndex = 15;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // VeriDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Firma_Arama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVeri);
            this.Controls.Add(this.Firma_Arama_DataGridView1);
            this.Controls.Add(this.Btngeri);
            this.Controls.Add(this.BtnCikis);
            this.Name = "VeriDepo";
            this.Text = "VeriDepo";
            ((System.ComponentModel.ISupportInitialize)(this.Firma_Arama_DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Firma_Arama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVeri;
        private System.Windows.Forms.DataGridView Firma_Arama_DataGridView1;
        private System.Windows.Forms.Button Btngeri;
        private System.Windows.Forms.Button BtnCikis;
    }
}