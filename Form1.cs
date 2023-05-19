namespace faktöriyelHesaplamaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int FaktoriyelHesapla(int sayi) //Faktoriyel hesaplama fonksiyonu
        {
            if (sayi == 0) //eğere sayi sifir olursa 1 donecek
                return 1;

            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++) // dongu ile sayiya kadar olan sayilari carparak hesaplama 
            {
                faktoriyel *= i;
            }
            return faktoriyel; // sonucu dondurme
        }

        private bool AsalKontrol(int sayi) //Asal sayi kontrol fonksiyonu
        {
            if (sayi < 2) // sayi ikiden kucuk ise asal degildir
                return false;

            for (int i = 2; i < sayi; i++) // ikiden sayiya kadar dongu donuyor
            {
                if (sayi % i == 0) // eger sayi i'e tam bolunuyorsa yani modu sifira esitse asal degildir
                    return false;
            }

            return true; // yukarida kontrolden gecen sayi asaldir
        }

        private void OncekiSayilar(int sayi) //Onceki sayilari gosterme fonksiyonu
        {
            string faktoriyelOncekiSayilari = ""; //bos bir string olusturuyoruz

            for (int i = 1; i <= sayi; i++) // dongu ile 1 den baslayarak sayiya kadar donuyoruz
            {
                if (i % 7 == 0) // Her 7 sayıda bir yeni satır karakteri ekle
                {
                    faktoriyelOncekiSayilari += "\n";
                }

                faktoriyelOncekiSayilari += i.ToString() + "-"; //i nin degerini ve yanina virgul koyarak string icini doldurma


            }

            lbl_sayilar.Text = faktoriyelOncekiSayilari.TrimEnd('-'); // sonundaki virguli silme islmei ve labelda gosterme
        }

        private void btn_fakt_Click(object sender, EventArgs e)
        {
            try // try komutu ile hata yakalama yapma
            {
                int sayi = Convert.ToInt32(txt_box_sayi.Text); // textboxdan girirlen sayiyi alma
                string sonuc = FaktoriyelHesapla(sayi).ToString(); // fonskiyon cagirma
                lbl_faktor.Text = sonuc; //labelda gosterme
            }
            catch (Exception)
            {
                MessageBox.Show("LÜTFEN SAYI GİRİNİZ !!!"); // hata alinirsa mesaj kutusu ile kullaniciyi bilgilendirme
            }

        }

        private void btn_asal_Click(object sender, EventArgs e)
        {
            try // try komutu ile hata yakalama yapma
            {
                int sayi = Convert.ToInt32(txt_box_sayi.Text); // textboxdan girirlen sayiyi alma
                bool sonuc = AsalKontrol(sayi); // fonskiyon cagirma

                if (sonuc) //true olursa asaldir
                {
                    lbl_asal.Text = "Asal Sayı"; //labela gosterme
                }

                else // degilse asal degildir
                {
                    lbl_asal.Text = "Asal Sayı Değil"; //labela gosterme
                }

            }
            catch (Exception)
            {
                MessageBox.Show("LÜTFEN SAYI GİRİNİZ !!!"); // hata alinirsa mesaj kutusu ile kullaniciyi bilgilendirme
            }
        }

        private void btn_sayilar_Click(object sender, EventArgs e)
        {
            try // try komutu ile hata yakalama yapma
            {
                int sayi = Convert.ToInt32(txt_box_sayi.Text); // textboxdan girirlen sayiyi alma
                OncekiSayilar(sayi); // fonskiyon cagirma

            }
            catch (Exception)
            {
                MessageBox.Show("LÜTFEN SAYI GİRİNİZ !!!"); // hata alinirsa mesaj kutusu ile kullaniciyi bilgilendirme
            }

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); //uygulamayı kapat
        }
    }
}