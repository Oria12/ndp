
/********************************************************    
**              SAKARYA ÜNİVERSİTESİ
**     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**       BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**          NESNEYE DAYALI PROGRAMLAMA DERSİ 
**               2019-2020 BAHAR DÖNEMİ 
**
**                  ÖDEV NUMARASI: 1 
**             ÖĞRENCİ ADI: ORÇUN HOLTA
**            ÖĞRENCİ NUMARASI: B191200300
**               DERSİN ALINDIĞI GRUP: 
*********************************************************/






namespace ndpv1
{
    partial class kaybettin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kaybettin));
            this.yasamsuresi = new System.Windows.Forms.Label();
            this.kolonyasayin = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.toplampuan = new System.Windows.Forms.Label();
            this.tekraroyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yasamsuresi
            // 
            this.yasamsuresi.AutoSize = true;
            this.yasamsuresi.BackColor = System.Drawing.Color.Maroon;
            this.yasamsuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yasamsuresi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.yasamsuresi.Location = new System.Drawing.Point(155, 474);
            this.yasamsuresi.Name = "yasamsuresi";
            this.yasamsuresi.Size = new System.Drawing.Size(23, 25);
            this.yasamsuresi.TabIndex = 1;
            this.yasamsuresi.Text = "0";
            this.yasamsuresi.Click += new System.EventHandler(this.yasamsuresi_Click);
            // 
            // kolonyasayin
            // 
            this.kolonyasayin.AutoSize = true;
            this.kolonyasayin.BackColor = System.Drawing.Color.Maroon;
            this.kolonyasayin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolonyasayin.ForeColor = System.Drawing.Color.Yellow;
            this.kolonyasayin.Location = new System.Drawing.Point(520, 474);
            this.kolonyasayin.Name = "kolonyasayin";
            this.kolonyasayin.Size = new System.Drawing.Size(23, 25);
            this.kolonyasayin.TabIndex = 3;
            this.kolonyasayin.Text = "0";
            // 
            // cikis
            // 
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.Location = new System.Drawing.Point(393, 593);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(123, 55);
            this.cikis.TabIndex = 4;
            this.cikis.Text = "Oyundan Çık";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // toplampuan
            // 
            this.toplampuan.AutoSize = true;
            this.toplampuan.BackColor = System.Drawing.Color.Maroon;
            this.toplampuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplampuan.ForeColor = System.Drawing.Color.Transparent;
            this.toplampuan.Location = new System.Drawing.Point(336, 538);
            this.toplampuan.Name = "toplampuan";
            this.toplampuan.Size = new System.Drawing.Size(29, 31);
            this.toplampuan.TabIndex = 7;
            this.toplampuan.Text = "0";
            // 
            // tekraroyna
            // 
            this.tekraroyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tekraroyna.Location = new System.Drawing.Point(204, 593);
            this.tekraroyna.Name = "tekraroyna";
            this.tekraroyna.Size = new System.Drawing.Size(123, 55);
            this.tekraroyna.TabIndex = 8;
            this.tekraroyna.Text = "Ana Menüye Dön";
            this.tekraroyna.UseVisualStyleBackColor = true;
            this.tekraroyna.Click += new System.EventHandler(this.tekraroyna_Click);
            // 
            // kaybettin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.tekraroyna);
            this.Controls.Add(this.toplampuan);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.kolonyasayin);
            this.Controls.Add(this.yasamsuresi);
            this.Name = "kaybettin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kaybettin";
            this.Load += new System.EventHandler(this.kaybettin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yasamsuresi;
        private System.Windows.Forms.Label kolonyasayin;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label toplampuan;
        private System.Windows.Forms.Button tekraroyna;
    }
}