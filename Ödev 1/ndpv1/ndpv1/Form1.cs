
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
    public partial class Form1 : Form
    {

        public static int gideceksayac;   //Kaybettin ekranına sayac değerini ve kolonya değerini göndermek için tanımladığım değişken
        public static int gidecekkolonya; //Kaybettin ekranına kolonya değerini göndermek için tanımladığım değişken

        public Form1()
        {
            InitializeComponent();
       
            //Arkaplanı transparan yapmak için gerekli kod
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;

        }


        Random rnd = new Random();    //Random değer oluşturmak için tanımladığım rnd isimli değişkenim


        //Düşmanların standart hız değerleri
        int dusmanhizisol = 5; 
        int dusmanhizisag = 7; 
        int dusmanhiziust = 6; 
        int dusmanhizialt = 3; 


        int genelsayac;    //Oyunun hızını kontrol etmek için gerekli olan sayaç

    
        private void Form1_Load(object sender, EventArgs e)
        {

            zaman.Enabled = false;
            kronometre.Enabled = false;
            kolonya.Visible = true;
            dezenfektan.Visible = true;
            kolonyapanel.Visible = false;
            nasiloynanirpanel.Visible = false;
         
        }



        private void oyna_Click(object sender, EventArgs e)
        {

            oyna.Visible = false;
            nasiloynanir.Visible = false;
            nasiloynanirpanel.Visible = false;
            anamenu.Visible = false;
            kolonyapanel.Visible = true;

            zaman.Enabled = true;
            kronometre.Enabled = true;


            //Karakterin, toplanabilirlerin ve düşmanların lokasyonlarını ayarlıyor
            karakter.Location = new Point(326, 300);
            kolonya.Location = new Point(700, 700);
            dezenfektan.Location = new Point(700, 700);
     
            sold1.Location = new Point(-110, 10);
            sold2.Location = new Point(-110, 395);
            sagd1.Location = new Point(750, 181);
            sagd2.Location = new Point(750, 10);
            ustd1.Location = new Point(10, -110);
            ustd2.Location = new Point(380, -110);
            altd1.Location = new Point(200, 715);
            altd2.Location = new Point(10, 715);


        }


        private void nasiloynanir_Click(object sender, EventArgs e)
        {
            nasiloynanirpanel.Visible = true;
            nasiloynanir.Visible = false;
        }


 
        private void zaman_Tick(object sender, EventArgs e)
        {

            /*Burada bir x düşüncesi oluşturuyorum ve diyorum ki eğer x(herhangi bir nesne) picturebox ise ve Tag'i Dusmansag ise 
            onu dusmanhizisag değişkeninin tersi yöne yani sola doğru gönder. Aynı işlemleri diğer düşmanlar ve yönler için de uyguluyorum */
            // Sağdan Sola Olanlar İçin
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Dusmansag")
                    x.Left -= dusmanhizisag;

                /*Eğer bu picturebox ekranın soluna yeteri kadar yaklaşırsa lokasyonunu x de istediğim yere
                 y de ise rastgele bir yere koy. Aynı işlemleri diğer düşmanlar ve yönler için uyguluyorum */
                if (x.Left < -110)
                {
                    x.Left = 700;

                    int lokasyonx = sagd2.Location.X;
                    int lokasyony = sagd2.Location.Y;
                    lokasyonx = 700;
                    lokasyony = rnd.Next(0, 642);
                    sagd2.Location = new Point(lokasyonx, lokasyony);

                }
            }

            // Soldan Sağa Olanlar İçin
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Dusmansol")
                    x.Left += dusmanhizisol;

                if (x.Left > 700)
                {
                    x.Left = -110;

                    int lokasyonx = sold1.Location.X;
                    int lokasyony = sold1.Location.Y;
                    lokasyonx = -110;
                    lokasyony = rnd.Next(0, 642);
                    sold1.Location = new Point(lokasyonx, lokasyony);

                }
            }

            // Üstten Aşağı Olanlar İçin
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Dusmanust")
                    x.Top += dusmanhiziust;

                if (x.Top > 700)
                {
                    x.Top = -110;

                    int lokasyonx = ustd1.Location.X;
                    int lokasyony = ustd1.Location.Y;
                    lokasyony = -110;
                    lokasyonx = rnd.Next(0, 662);
                    ustd1.Location = new Point(lokasyonx, lokasyony);

                }
            }

            // Alttan Yukarı OLanlar İçin
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Dusmanalt")
                    x.Top -= dusmanhizialt;

                if (x.Top < -110)
                {
                    x.Top = 700;

                    int lokasyonx = altd2.Location.X;
                    int lokasyony = altd2.Location.Y;
                    lokasyony = 700;
                    lokasyonx = rnd.Next(0, 662);
                    altd2.Location = new Point(lokasyonx, lokasyony);

                }
            }



            //Eğer karakterimle herhangi bir düşmanın sınırları kesişirse yani birbirlerine değerlerse olacak işlem için if 
            if (karakter.Bounds.IntersectsWith(sold1.Bounds) || karakter.Bounds.IntersectsWith(sold2.Bounds)
              || karakter.Bounds.IntersectsWith(sagd1.Bounds) || karakter.Bounds.IntersectsWith(sagd2.Bounds)
              || karakter.Bounds.IntersectsWith(ustd1.Bounds) || karakter.Bounds.IntersectsWith(ustd2.Bounds)
              || karakter.Bounds.IntersectsWith(altd1.Bounds) || karakter.Bounds.IntersectsWith(altd2.Bounds))
            {
                karakter.BackColor = Color.Red;

                
                zaman.Enabled = false;
                kronometre.Enabled = false;

                gideceksayac = genelsayac;   //en üstte tanımladığım parametreye genelsayacı eşitliyorum

                Form1.ActiveForm.Hide();   //Form1 formumu yani oyun sayfasını gizliyorum
                kaybettin frm2 = new kaybettin();   //kaybettin ismindeki form sayfama frm2 ismini veriyorum
                frm2.ShowDialog();   //frm2 ismini verdiğim kaybettin form sayfamı açıyorum
                
            }




            //Eğer karakterimle herhangi bir kolonyanın sınırları kesişirse yani birbirlerine değerlerse olacak işlem için if 
            if (karakter.Bounds.IntersectsWith(kolonya.Bounds))
            {
                int kolonyasayi = Convert.ToInt32(kolonyasayisi.Text);
                kolonyasayi++;
                kolonyasayisi.Text = kolonyasayi.ToString();


                kolonya.Location = new Point(700, 700); //Sayacın yalnızca 1 artabilmesi için dokunulduğu anda gene karakterin erişemeyeceği bir noktaya gönderiyorum

                kolonya.Visible = false;

                int aktarilankolonya = kolonyasayi; //kolonyasayi problem çıkarttığı için aktarilankolonya diye bir değişken tanımlıyorum
                gidecekkolonya = aktarilankolonya;  //gidecekkolonyaya aktarilankolonyayı eşitleyip öbür fromda gidecekkolonyayı çağırıyorum
                
            }



            //Eğer karakterimle herhangi bir dezenfektanın sınırları kesişirse yani birbirlerine değerlerse olacak işlem için if 
            if (karakter.Bounds.IntersectsWith(dezenfektan.Bounds))
            {
                karakter.BackColor = Color.SkyBlue;


                dezenfektan.Location = new Point(700, 700); //Sayacın yalnızca 1 artabilmesi için dokunulduğu anda gene karakterin erişemeyeceği bir noktaya gönderiyorum
                dezenfektan.Visible = false;

            }



        }



        private void kronometre_Tick(object sender, EventArgs e)
        {

            //Hayatta kalma süresini labelda göstermek için bulunan kısım
            int sayac = int.Parse(survive.Text);
            sayac++;
            survive.Text = sayac.ToString();

            genelsayac++; /*genelsayacı en üstte tanımladım ki tushareketinde de kullanabileyim, burada ise...
                            kronometrenin intervali 1000 olduğu için saniye şeklinde arttırmış oldum */
           



            //Kolonyanın belirli zaman aralıklarında rastgele bir yerde oluşması oluşması
            if (sayac == 5 || sayac == 15 || sayac == 25 || sayac == 35 || sayac == 45 || sayac == 55 || sayac == 65 || sayac == 75 || sayac == 85 || sayac == 95
                || sayac == 105 || sayac == 115 || sayac == 125 || sayac == 135 || sayac == 145 || sayac == 155 || sayac == 165 || sayac == 175 || sayac == 185 || sayac == 195)
            {
                kolonya.Visible = true;
                int kolonyax = kolonya.Location.X;
                int kolonyay = kolonya.Location.Y;
            

                kolonyax = rnd.Next(30, 632);
                kolonyay = rnd.Next(30, 576);
                kolonya.Location = new Point(kolonyax, kolonyay);
            }

            //Kolonyanın karakterine gidemeyeceği yerde oluşması (bu şekilde yok olması)
            if (sayac == 10 || sayac == 20 || sayac == 30 || sayac == 40 || sayac == 50 || sayac == 60 || sayac == 70 || sayac == 80 || sayac == 90 || sayac == 100
               || sayac == 110 || sayac == 120 || sayac == 130 || sayac == 140 || sayac == 150 || sayac == 160 || sayac == 170 || sayac == 180)
            {
                kolonya.Location = new Point(700, 700);
            }






            //Dezenfektanın belirli zaman aralıklarında rastgele bir yerde oluşması oluşması
            if (sayac == 10 || sayac == 35 || sayac == 60 || sayac == 85 || sayac == 110 || sayac == 145 || sayac == 170 || sayac == 200)
            {
                dezenfektan.Visible = true;
                int dezenfektanx = dezenfektan.Location.X;
                int dezenfektany = dezenfektan.Location.Y;

                dezenfektanx = rnd.Next(30, 632);
                dezenfektany = rnd.Next(30, 576);
                dezenfektan.Location = new Point(dezenfektanx, dezenfektany);
            }

            //Dezenfektanın karakterin gidemeyeceği yerde oluşması (bu şekilde yok olması)
            if (sayac == 15 || sayac == 40 || sayac == 65 || sayac == 90 || sayac == 115 || sayac == 150 || sayac == 175 || sayac == 205)
            {
                dezenfektan.Location = new Point(700, 700);
            }

           

           

             /*genelsayac değişkenim 0 dan sonsuza kadar artıyor onun belirli zamanlarında oyunun hızının bulunduğu timer olan
               zaman timer'ının intervalini değiştiriyorum ki düşmanlar daha hızlı şekilde gelsinler.
               Yani aslında düşmanlar hızlanmıyor oyunun hızı yavaşlıyor. */
           switch (genelsayac)
           {

               case 1:
                   zaman.Interval = 90;
                   break;         
               case 10:
                   zaman.Interval = 85;
                   break;
               case 15:
                   zaman.Interval = 80;
                   break;
               case 20:
                   zaman.Interval = 75;
                   break;
               case 25:
                   zaman.Interval = 70;
                   break;
               case 30:
                   zaman.Interval = 65;
                   break;
               case 35:
                   zaman.Interval = 60;
                   break;
               case 40:
                   zaman.Interval = 55;
                   break;
               case 45:
                   zaman.Interval = 50;
                   break;
               case 50:
                   zaman.Interval = 45;
                   break;
               case 55:
                   zaman.Interval = 40;
                   break;
               case 60:
                   zaman.Interval = 37;
                   break;
               case 65:
                   zaman.Interval = 34;
                   break;
               case 70:
                   zaman.Interval = 31;
                   break;
               case 75:
                   zaman.Interval = 28;
                   break;
               case 80:
                   zaman.Interval = 26;
                   break;
               case 85:
                   zaman.Interval = 24;
                   break;
               case 90:
                   zaman.Interval = 22;
                   break;
               case 95:
                   zaman.Interval = 20;
                   break;
               case 100:
                   zaman.Interval = 18;
                   break;
               case 105:
                   zaman.Interval = 16;
                   break;
               case 110:
                   zaman.Interval = 14;
                   break;
               case 115:
                   zaman.Interval = 12;
                   break;
               case 120:
                   zaman.Interval = 10;
                   break;
               case 130:
                   zaman.Interval = 8;
                   break;
               case 140:
                   zaman.Interval = 6;
                   break;
              

         
           }
            //zaman.Interval=5 zaten çok hızlı olduğu için oyunun saniyesi belirli bir süreye geldiğinde sabitliyorum.
           if (sayac > 144)
           {
               zaman.Interval = 5;
           }
                 
                           
        }



      
        private void Tushareket(object sender, KeyEventArgs e)
        {

            /* Karakterimi hareket ettirmek için x ve y değerlerine karakterin x ve y değerlerini atıyorum sonra 
            klavyeden basılan tuşa ve konumun haritanın dışında olmamasına dikkat ederek karakteri hareket ettiriyorum  */
            int x = karakter.Location.X;
            int y = karakter.Location.Y;


            if (e.KeyCode == Keys.W && y > 10)
            {
                y = y - 16;
            }

            if (e.KeyCode == Keys.A && x > 10)
            {
                x = x - 16;
            }

            if (e.KeyCode == Keys.S && y < 625)
            {
                y = y + 16;
            }

            if (e.KeyCode == Keys.D && x < 635)
            {
                x = x + 16;
            }

            karakter.Location = new Point(x, y);




           /* Eğer karakterin arkaplanı Mavi olduysa yani herhangi bir dezenfektana değdiyse ve oyuncu Q tuşuna basarsa tüm
            düşmanların yerlerini başlangıç lokasyonuna ayarlıyorum. Karakterin arkaplanını da tekrar transparan yapıyorum */
            if (karakter.BackColor == Color.SkyBlue && e.KeyCode == Keys.Q) 
            {
                  
                sold1.Location = new Point(-110, 10);
                sold2.Location = new Point(-110, 395);
                sagd1.Location = new Point(750, 181);
                sagd2.Location = new Point(750, 10);
                ustd1.Location = new Point(10, -110);
                ustd2.Location = new Point(380, -110);
                altd1.Location = new Point(200, 715);
                altd2.Location = new Point(10, 715);

                karakter.BackColor = Color.Transparent;
                
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ustd1_Click(object sender, EventArgs e)
        {

        }

        private void ustd2_Click(object sender, EventArgs e)
        {

        }

        private void nasiloynanirpanel_Paint(object sender, PaintEventArgs e)
        {

        }

   

    }
}
