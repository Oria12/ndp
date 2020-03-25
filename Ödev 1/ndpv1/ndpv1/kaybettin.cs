
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




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndpv1
{
    public partial class kaybettin : Form
    {

        

        public kaybettin()
        {
            InitializeComponent();
        }

        private void kaybettin_Load(object sender, EventArgs e)
        {

            //Bu iki satırda formumdaki labellara diğer formdan bilgi getiriyorum
            yasamsuresi.Text = Form1.gideceksayac.ToString();
            kolonyasayin.Text = Form1.gidecekkolonya.ToString();


            int kolonyasayisi, yasamsuresisayisi, toplamp;  //integer değerler tanımlıyorum ki labeldaki verileri aktarıp toplam da gösterebileyim

            kolonyasayisi = Convert.ToInt32(kolonyasayin.Text);
            yasamsuresisayisi = Convert.ToInt32(yasamsuresi.Text);

            //Toplam puanı hayatta kalınan süre + toplanan kolonya sayısının 5 katına eşitliyorum. Bu şekilde 1 kolonya 5 puana denk geliyor.
            toplamp = yasamsuresisayisi + (kolonyasayisi*5);

            toplampuan.Text = toplamp.ToString();
        }


        

        private void yasamsuresi_Click(object sender, EventArgs e)
        {

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            //Kullanıcı Çıkış butonuna bastığında onun için bir dialog oluşturuyorum. Dialogun cevabı evet ise oyundan çıkartıyorum.
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Oyundan çıkmak istediğine emin misin?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            
        }

        private void tekraroyna_Click(object sender, EventArgs e)
        {
           
            kaybettin.ActiveForm.Hide();  //Kullanıcı tekrar oyna butonuna basarsa kaybettin formumu kapatıyorum
            Form1 frm1 = new Form1();     //Form1 formuma frm1 ismini veriyorum.
            frm1.ShowDialog();            //frm1 isimli dosyamı açıyorum.
        }
    }
}
