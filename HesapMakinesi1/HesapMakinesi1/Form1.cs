using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HesapMakinesi1
{
    public partial class Form1 : Form
    {

       
        double cevap = 0;//cevap değişkenini global de tanımladım çünkü bir çok yerde kullanıldı.

        bool islem = true; // bool tipinde işlem değişkeni oluşturup true diyoruz,
                           //aşağıda bu değişkeni kullanarak label1 ve label3 arasındaki
                           //geçişi sağlıyorum.
        
        char secim;// operatör seçimlerimi char seçim değişkenine aktarıyor.
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if (islem)
            {   //işlem true olarak başlıyor label1 e işlemi yazdıyoruz.
                label1.Text += "0";

                
            }
            //aşağıda operatöre tıklanınca islem değişkenini tekrar false yapılıyor.
            else
            {//işlem false olduktan sonra label 3 e geçişi sağlıyor.
                label3.Text += "0";

            }



        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (islem)
            {//işlem true olarak başlıyor label1 e işlemi yazdıyoruz.
                label1.Text += "1";

            }
            //aşağıda operatöre tıklanınca islem değişkenini tekrar false yapılıyor.
            else
            {//işlem false olduktan sonra label 3 e geçişi sağlıyor.
                label3.Text += "1";

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (islem)
            {//işlem true olarak başlıyor label1 e işlemi yazdıyoruz.
                label1.Text += "2";

            }
            //aşağıda operatöre tıklanınca islem değişkenini tekrar false yapılıyor.
            else
            {//işlem false olduktan sonra label 3 e geçişi sağlıyor.
                label3.Text += "2";

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (islem)
            {//işlem true olarak başlıyor label1 e işlemi yazdıyoruz.
                label1.Text += "3";

            }
            //aşağıda operatöre tıklanınca islem değişkenini tekrar false yapılıyor.
            else
            {//işlem false olduktan sonra label 3 e geçişi sağlıyor.
                label3.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (islem)
            {//işlem true olarak başlıyor label1 e işlemi yazdıyoruz.
                label1.Text += "4";

            }
            //aşağıda operatöre tıklanınca islem değişkenini tekrar false yapılıyor.
            else
            {//işlem false olduktan sonra label 3 e geçişi sağlıyor.

                label3.Text += "4";

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (islem)
            {//işlem true olarak başlıyor label1 e işlemi yazdıyoruz.
                label1.Text += "5";
            }
            //aşağıda operatöre tıklanınca islem değişkenini tekrar false yapılıyor.
            else
            {//işlem false olduktan sonra label 3 e geçişi sağlıyor.
                label3.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (islem)
            {//işlem true olarak başlıyor label1 e işlemi yazdıyoruz.
                label1.Text += "6";
            }
            //aşağıda operatöre tıklanınca islem değişkenini tekrar false yapılıyor.
            else
            {//işlem false olduktan sonra label 3 e geçişi sağlıyor.
                label3.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (islem)
            {//işlem true olarak başlıyor label1 e işlemi yazdıyoruz.
                label1.Text += "7";
            }
            //aşağıda operatöre tıklanınca islem değişkenini tekrar false yapılıyor.
            else
            {//işlem false olduktan sonra label 3 e geçişi sağlıyor.
                label3.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (islem)
            {//işlem true olarak başlıyor label1 e işlemi yazdıyoruz.
                label1.Text += "8";
            }
            //aşağıda operatöre tıklanınca islem değişkenini tekrar false yapılıyor.
            else
            {//işlem false olduktan sonra label 3 e geçişi sağlıyor.
                label3.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (islem)
            {//işlem true olarak başlıyor label1 e işlemi yazdıyoruz.
                label1.Text += "9";
            }
            //aşağıda operatöre tıklanınca islem değişkenini tekrar false yapılıyor.
            else
            {//işlem false olduktan sonra label 3 e geçişi sağlıyor.
                label3.Text += "9";
            }
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            islem = false;//label3 e geçiş için false yapıyor.
            secim = '*';//seçim değişkenine çarpımı atadık.
            label2.Text = "*";//çarpı işaretine tıklayınca label2 ye * koyduk.
            if (label4.Text != "")
            {
                //burada tekrar  * tıklanınca label4 yani sonuç textim boştan farklı ise 
                //label1'e cevabı gönderiyoruz çünkü çıkan sonuç üzerinden tekrar işlem 
                //yapmamıza izin veriyor.

                label1.Text = cevap.ToString("F3");
                label3.Text = "";
            }
            if (label1.Text == "")
            {
                //label1 yani ilk sayi girilmemiş ise message kutusunun warning iconu ile 
                //kullanıcıya bilgilendirme mesajı veriyor.
                MessageBox.Show("İlk sayi girilmeden işlem girilemez.", "Dikkat!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);

                label2.Text = "";
                islem = true;
            }
            label6.Visible = false;
            //label6.visible false yapma sebebim geçmişi göster dedikten sonra geçmiş gösterilir
            //daha sonrasında tekrar bir işlem yapılmak istendiğinde operatörlere basılınca geçmişi
            //tekrar gizliyor.daha sonrasında tekrar geçmiş butonuna basarak bütün geçmişi tekrar 
            //gösteriyor.


        }

        private void btnters_Click(object sender, EventArgs e)
        {
            if (label3.Text != "")
            {
                //boştan farklı ise yani içerisinde değer var ise bu if içerisine giriyor 
                //label3 içerisindeki işlemi -1 ile çarparak tersine çeviriyor.

                label3.Text = (Convert.ToDouble(label3.Text) * -1).ToString();

            }

            else if (label1.Text != "")
            {
                //boştan farklı ise yani içerisinde değer var ise bu if içerisine giriyor 
                //label1 içerisindeki işlemi -1 ile çarparak tersine çeviriyor.

                label1.Text = (Convert.ToDouble(label1.Text) * -1).ToString();//önce double sonra tekrar string;
            }




        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            islem = false;//label3 e geçiş için false yapıyor.
            secim = '+';//seçim değişkenine toplamı atadık.
            label2.Text = "+";//topla işaretine tıklayınca label2 ye + koyduk.
            if (label4.Text != "")
            {

                //burada tekrar  + tıklanınca label4 yani sonuç textim boştan farklı ise 
                //label1'e cevabı gönderiyoruz çünkü çıkan sonuç üzerinden tekrar işlem 
                //yapmamıza izin veriyor.

                label1.Text = cevap.ToString("F3");
                label3.Text = "";
            }
            if (label1.Text == "")
            {
                //label1 yani ilk sayi girilmemiş ise message kutusunun warning iconu ile 
                //kullanıcıya bilgilendirme mesajı veriyor.,

                MessageBox.Show("İlk sayi girilmeden işlem girilemez.", "Dikkat!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                label2.Text = "";
                islem = true;
            }
            label6.Visible = false;
            //label6.visible false yapma sebebim geçmişi göster dedikten sonra geçmiş gösterilir
            //daha sonrasında tekrar bir işlem yapılmak istendiğinde operatörlere basılınca geçmişi
            //tekrar gizliyor.daha sonrasında tekrar geçmiş butonuna basarak bütün geçmişi tekrar 
            //gösteriyor.




        }

        private void btncıkar_Click(object sender, EventArgs e)
        {
            islem = false;//label3 e geçiş için false yapıyor.
            secim = '-';//seçim değişkenine Çıkarmayı atadık.
            label2.Text = "-";//- işaretine tıklayınca label2 ye - koyduk.
            if (label4.Text != "")
            {

                //burada tekrar  - tıklanınca label4 yani sonuç textim boştan farklı ise 
                //label1'e cevabı gönderiyoruz çünkü çıkan sonuç üzerinden tekrar işlem 
                //yapmamıza izin veriyor.

                label1.Text = cevap.ToString("F3");
                label3.Text = "";
            }
            if (label1.Text == "")
            {
                //label1 yani ilk sayi girilmemiş ise message kutusunun warning iconu ile 
                //kullanıcıya bilgilendirme mesajı veriyor.
                MessageBox.Show("İlk sayi girilmeden işlem girilemez.", "Dikkat!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                label2.Text = "";
                islem = true;
            }
            label6.Visible = false;
            //label6.visible false yapma sebebim geçmişi göster dedikten sonra geçmiş gösterilir
            //daha sonrasında tekrar bir işlem yapılmak istendiğinde operatörlere basılınca geçmişi
            //tekrar gizliyor.daha sonrasında tekrar geçmiş butonuna basarak bütün geçmişi tekrar 
            //gösteriyor.

        }

        private void btnbolme_Click(object sender, EventArgs e)
        {
            islem = false;//label3 e geçiş için false yapıyor.
            secim = '/';//seçim değişkenine Bölmeyi atadık.
            label2.Text = "/";// / işaretine tıklayınca label2 ye / koyduk.
            if (label4.Text != "")
            {

                //burada tekrar  * tıklanınca label4 yani sonuç textim boştan farklı ise 
                //label1'e cevabı gönderiyoruz çünkü çıkan sonuç üzerinden tekrar işlem 
                //yapmamıza izin veriyor.

                label1.Text = cevap.ToString("F3");
                label3.Text = "";
            }
            if (label1.Text == "")
            {
                //label1 yani ilk sayi girilmemiş ise message kutusunun warning iconu ile 
                //kullanıcıya bilgilendirme mesajı veriyor.

                MessageBox.Show("İlk sayi girilmeden işlem girilemez.", "Dikkat!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                label2.Text = "";
                islem = true;
            }
            label6.Visible = false;
            //label6.visible false yapma sebebim geçmişi göster dedikten sonra geçmiş gösterilir
            //daha sonrasında tekrar bir işlem yapılmak istendiğinde operatörlere basılınca geçmişi
            //tekrar gizliyor.daha sonrasında tekrar geçmiş butonuna basarak bütün geçmişi tekrar 
            //gösteriyor.

        }



        private void btnesittir_Click(object sender, EventArgs e)
        {
            int birler = 0, onlar = 0, yuzler = 0, binler = 0;//Cevabın basamaklari için oluşturulmuş değişkenler


            if (label3.Text == "")
            {
                //label3 boş ise yani ikinci sayı girilmedi ise message kutusunun warning iconu ile 
                //kullanıcıya uyarı veriyor.
                MessageBox.Show("İkinci sayı girilmedi.", "Dikkat!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }
            else//ikinci sayı girilmiş ise işlemlere buradan devam ediyor.
            {
                //label1 den birinci sayıyı alıp double yapıyor.
                double birincisayi = Convert.ToDouble(label1.Text);
                //label3 den ikinci sayıyı alıp double yapıyor.
                double ikincisayi = Convert.ToDouble(label3.Text);
                if (secim == '+')
                {
                    //yukarıda operatörlere + - * / atamıştık.İf ile hangisine tıklandıgını anlıyoruz.
                    cevap = birincisayi + ikincisayi;//cevap değişkenine işlemi yaptırıyoruz.
                    label4.Text = "=" + cevap.ToString("F3") + " " + "A";
                    //f3 Kullanılma amacı virgülden sonra 3 basamak göstermesi içindir. ;
                    //A İFADESİ AŞAĞIDA AÇIKLANDI!
                }

                else if (secim == '-')
                {
                    //yukarıda operatörlere + - * / atamıştık.İf ile hangisine tıklandıgını anlıyoruz.
                    cevap = birincisayi - ikincisayi;//cevap değişkenine işlemi yaptırıyoruz.
                    label4.Text = "=" + cevap.ToString("F3") + " " + "A";
                    //f3 Kullanılma amacı virgülden sonra 3 basamak göstermesi içindir. ; 
                    //A İFADESİ AŞAĞIDA AÇIKLANDI!
                }

                else if (secim == '/')
                {
                    //yukarıda operatörlere + - * / atamıştık.İf ile hangisine tıklandıgını anlıyoruz.
                    cevap = birincisayi / ikincisayi;//cevap değişkenine işlemi yaptırıyoruz.
                    if (ikincisayi == 0)
                    {
                        label4.Text = "∞";
                    }
                    label4.Text = "=" + cevap.ToString("F3") + " " + "A";
                    //f3 Kullanılma amacı virgülden sonra 3 basamak göstermesi içindir. ; 
                    //A İFADESİ AŞAĞIDA AÇIKLANDI!
                }

                else if (secim == '*')
                {
                    //yukarıda operatörlere + - * / atamıştık.İf ile hangisine tıklandıgını anlıyoruz.
                    cevap = birincisayi * ikincisayi;//cevap değişkenine işlemi yaptırıyoruz.
                    label4.Text = "=" + cevap.ToString("F3") + " " + "A";
                    //f3 Kullanılma amacı virgülden sonra 3 basamak göstermesi içindir. ; 
                    //A İFADESİ AŞAĞIDA AÇIKLANDI!
                }

                else if (secim == 'P')
                {
                    //yukarıda operatörlere + - * / atamıştık.İf ile hangisine tıklandıgını anlıyoruz.
                    double taban = Convert.ToDouble(label1.Text);
                    double us = Convert.ToDouble(label3.Text);
                    cevap = Math.Pow(taban, us);//cevap değişkenine işlemi yaptırıyoruz.
                    label4.Text = "=" + cevap.ToString("F3") + " " + "A";
                    //f3 Kullanılma amacı virgülden sonra 3 basamak göstermesi içindir. ; 
                    //A İFADESİ AŞAĞIDA AÇIKLANDI!

                }

                else if (secim == 'E')
                {
                    //yukarıda operatörlere + - * / atamıştık.İf ile hangisine tıklandıgını anlıyoruz.
                    double sayi1 = Convert.ToDouble(label1.Text);
                    double sayi2 = Convert.ToDouble(label3.Text);
                    while (sayi2 != 0)
                    {
                        double kalan = sayi1 % sayi2;
                        sayi1 = sayi2;
                        sayi2 = kalan;
                    }
                    cevap = sayi1;
                    label4.Text = "=" + cevap.ToString("F3") + " " + "A";
                    //f3 Kullanılma amacı virgülden sonra 3 basamak göstermesi içindir. ; 
                    //A İFADESİ AŞAĞIDA AÇIKLANDI!
                }

                else if (secim == 'K')
                {
                    //yukarıda operatörlere + - * / atamıştık.İf ile hangisine tıklandıgını anlıyoruz.
                    double sayi1 = Convert.ToDouble(label1.Text);
                    double sayi2 = Convert.ToDouble(label3.Text);

                    double max = sayi1 * sayi2;
                    double ekok = 0;
                    /* 2 sayı eger aralarında asal ise ekoku
                    çarpımlarıdır. Yanı 2 sayının ekoku maximum çarpımlarıdır.*/

                    // max değerinden başlayarak 0'a kadar olan sayıları azaltarak kontrol et.
                    for (double i = max; i > 0; i--)
                    {
                        // Eğer i, hem sayi1 hem de sayi2'ye bölünebiliyorsa,
                        if (i % sayi1 == 0 && i % sayi2 == 0)
                        {
                            // i değerini ekok değişkenine ata.
                            ekok = i;
                        }
                    }
                    cevap = ekok;
                    label4.Text = "=" + cevap.ToString("F3") + " " + "A";
                    //f3 Kullanılma amacı virgülden sonra 3 basamak göstermesi içindir. ; 
                    //A İFADESİ AŞAĞIDA AÇIKLANDI!
                }

                else if (secim == 'M')
                {
                    //yukarıda operatörlere + - * / atamıştık.İf ile hangisine tıklandıgını anlıyoruz.
                    double sayi1 = Convert.ToDouble(label1.Text);
                    double sayi2 = Convert.ToDouble(label3.Text);
                    cevap = sayi1 % sayi2;//cevap değişkenine işlemi yaptırıyoruz.
                    label4.Text = "=" + cevap.ToString("F3") + " " + "A";
                    //f3 Kullanılma amacı virgülden sonra 3 basamak göstermesi içindir. ; 
                    //A İFADESİ AŞAĞIDA AÇIKLANDI!




                }

                else if (secim == 'S')
                {
                    //yukarıda operatörlere + - * / atamıştık.İf ile hangisine tıklandıgını anlıyoruz.
                    double sayi1 = Convert.ToDouble(label1.Text);
                    double sayi2 = Convert.ToDouble(label3.Text);
                    cevap = (Math.Sqrt(sayi2)) * Convert.ToDouble(label1.Text);//cevap değişkenine işlemi yaptırıyoruz.
                    label4.Text = "=" + cevap.ToString("F3") + " " + "A";
                    //f3 Kullanılma amacı virgülden sonra 3 basamak göstermesi içindir. ; 
                    //A İFADESİ AŞAĞIDA AÇIKLANDI!


                }

                if (cevap > 0) //romen rakamlarını cevap sıfırdan buyuk ise yazıyor.
                {
                    // Cevap değişkeni 10'dan küçükse sadece birler basamağını alır.
                    if (cevap < 10) 
                        birler = Convert.ToInt32(cevap);
                    // Cevap değişkeni 10 ile 99 arasında ise onlar ve birler basamağını alır.
                    if (cevap > 9 && cevap < 100)
                    {
                        onlar = Convert.ToInt32(cevap) / 10;
                        birler = Convert.ToInt32(cevap) - (onlar * 10);
                    }
                    // Cevap değişkeni 100 ile 999 arasında ise yüzler, onlar ve birler basamağını alır.
                    if (cevap > 99 && cevap < 1000)
                    {
                        yuzler = Convert.ToInt32(cevap) / 100;
                        onlar = (Convert.ToInt32(cevap) - (yuzler * 100)) / 10;
                        birler = Convert.ToInt32(cevap) - ((yuzler * 100) + (onlar * 10));
                    }
                    // Cevap değişkeni 1000 ile 9999 arasında ise binler, yüzler, onlar ve birler basamağını alır.
                    if (cevap > 999 && cevap < 10000)
                    {

                        binler = Convert.ToInt32(cevap) / 1000;
                        yuzler = (Convert.ToInt32(cevap) - (binler * 1000)) / 100;
                        onlar = (Convert.ToInt32(cevap) - ((binler * 1000) + (yuzler * 100))) / 10;
                        birler = Convert.ToInt32(cevap) % 10;

                    }
                    // Roma rakamlarını saklamak için diziler oluşturulur. 
                    string[] dbirler = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
                    string[] donlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                    string[] dyuzler = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                    string[] dbinler = { "", "M", "MM", "MMM" };
                    // Her bir basamağın Roma rakamı karşılığı label4.Text'e eklenir.
                    label4.Text += dbinler[binler];
                    label4.Text += dyuzler[yuzler];
                    label4.Text += donlar[onlar];
                    label4.Text += dbirler[birler];



                    //LABEL4 ' E YAZDIRIRKEN SONA "A" EKLEME SEBEBİ AŞAĞIDA AÇIKLANMIŞTIR!
                    label4.Text = label4.Text.Replace("A", "(");
                    //Bu kısımda cevaptan daha sonra cevabın romen rakamı gösterileceği için başına parantez
                    //ve sonuna parantez koymak içindir. Yukarıda her cevap ifadesinin sonuna A harfi eklendi
                    //replace ile A ifadesi bulunan kısıma ( parantez açma konulur.

                    label4.Text = label4.Text.Insert(label4.Text.Length, ")");
                    //Bu kısım parantezin sonun kapatmayı gösteriyor.Insert ile cevabın length 'i kadar gidilir
                    //yani text in en sonuna ) parantez kapatma konulur.






                }
                else
                {
                    label4.Text = cevap.ToString("F3");
                    //bu kısımın else içerisinde bulunma sebebi romen rakamlarını yukarıda bağlantılı oldugu if
                    //içerisinde cevabın sıfırdan büyük olduğu durumlarda yazıyor.
                    //negatif sonuclarda romen rakamı ile yazılmıyor.
                }


            }

            
            label6.Text = label1.Text + "" + label2.Text + "" + label3.Text + "" + label4.Text + "" +"\n"+ label6.Text;

            //Bu kısımda history kısmını eşittir butonuna atma sebebim her eşittire basıldığında geçmiş olarak tutsun
            //geçmiş butonuna tıklanınca daha önceden eşittire tıklanıncaya kadar olan ki bütün işlemler gözüksün





        }

        private void btnc_Click(object sender, EventArgs e)
        {
            //Buton C 'ye basıldıgında bütün labellerin içerisini boş yapıyor. 
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            islem = true;
            //islemi tekrar true yapıp label1 içerisine girmeyi sağlıyor.Yani İlk sayıyı girmeyi sağlıyor.
        }

        private void btnce_Click(object sender, EventArgs e)
        {   // BUTON CE BULUNULAN LABELDAKİ İFADEYİ TAMAMEN SİLMEYİ SAĞLIYOR.
            if (label4.Text != "")
            { //sonuncu ifade yani cevaba kadar dolu ise bütün labelleri siliyor.
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                islem = true;//islemi true yaparak label1 den başlamamızı sağlıyor.
            }
            else if (label3.Text != "")
            { //label3 boştan farklı ise sadece label 3 ü siliyor.                           
                label3.Text = "";
            }
            else if (label2.Text != "")
            {
                //label2 deki operatörlerin silinmesine izin vermedim.
            }
            else if (label1.Text != "")
            {//label 1 boştan farklı ise yani dolu ise label 1 i siliyor
                label1.Text = "";
            }
            else
            {//hiçbir konumda değil ise label1 i boş yapıyor.
                label1.Text = "";
            }
        }

        private void btnvrgl_Click(object sender, EventArgs e)
        {
            //virgül butonuna islem = true ifadesinden başlıyo . Çünkü islem global de true olarak atandı.
            if (islem)
            {
                if (!label1.Text.Contains(","))//Bu ifade, label1.Text içinde virgül karakterinin olup olmadığını kontrol eder.
                {                              //olup olmama duruma göre true ya da false dönderir.
                    label1.Text = label1.Text + ","; //label1'e virgül yazılır.
                }
                if (label1.Text == ",")  //eğer direkt virgüle basıldıysa ifade 0,.. şeklinde olur.
                {
                    label1.Text = "0,";
                }
            }
            else
            {
                if (!label3.Text.Contains(","))//Bu ifade, label3.Text içinde virgül karakterinin olup olmadığını kontrol eder.
                {
                    label3.Text = label3.Text + ",";//label3'e virgül yazılır.
                }
                if (label3.Text == ",")//eğer direkt virgüle basıldıysa ifade 0,.. şeklinde olur.
                {
                    label3.Text = "0,";
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (islem && label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
                //substring=String bir değerin belirtilen bir yerinden
                //istenilen sayıda karakter almak için kullanılır.
                //0dan başlayıp en son değere kadar gidip son değeri almaktadır.
                //Tek Tek silme işlemi için substring kullanılmıştır.
            }
            else if (!islem && label3.Text.Length > 0)
            {
                label3.Text = label3.Text.Substring(0, label3.Text.Length - 1);
                //substring=String bir değerin belirtilen bir yerinden
                //istenilen sayıda karakter almak için kullanılır.
                //0dan başlayıp en son değere kadar gidip son değeri almaktadır.
                //Tek Tek silme işlemi için substring kullanılmıştır.
            }



        }

        private void btnpow_Click(object sender, EventArgs e)
        {
           
            islem = false; //ilk sayi girilir ve powa basıldıktan sonra işlem false olur ki ikinci sayi girilsin.
            label2.Text = "POW";//pow butonuna tıklanınca label2 ye POW yazdırılır.
            secim = 'P';//seçime p Atandı.
            if (label4.Text != "")
            {
                //burada tekrar  POW tıklanınca label4 yani sonuç textim boştan farklı ise 
                //label1'e cevabı gönderiyoruz çünkü çıkan sonuç üzerinden tekrar işlem 
                //yapmamıza izin veriyor.
                islem = true;
                label1.Text = cevap.ToString("F3");
                label3.Text = "";
                islem = false;
            }



            if (label1.Text == "")
            {   //label1 yani ilk sayi girilmemiş ise message kutusunun warning iconu ile 
                //kullanıcıya bilgilendirme mesajı veriyor.
                MessageBox.Show("İlk sayi girilmeden işlem girilemez.", "Dikkat!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                label2.Text = ""; //label2 boş yapılıp,
                islem = true;//islem true olur ve label1 e tekrar yazmamızı sağlar.
                //kısacası ilk sayi girilmediyse bilgilendirme uyarısından sonra tekrar label 1 den başlatır.
            }

            label6.Visible = false;
            //label6.visible false yapma sebebim geçmişi göster dedikten sonra geçmiş gösterilir
            //daha sonrasında tekrar bir işlem yapılmak istendiğinde operatörlere basılınca geçmişi
            //tekrar gizliyor.daha sonrasında tekrar geçmiş butonuna basarak bütün geçmişi tekrar 
            //gösteriyor.

        }

        private void btnebob_Click(object sender, EventArgs e)
        {
            islem = false; //ilk sayi girilir ve eboba basıldıktan sonra işlem false olur ki ikinci sayi girilsin.
            label2.Text = "EBOB";//label2.text ine Ebob Yazdirilir.
            secim = 'E'; // E Ebobu simgeler.Seçime E atandı.

            if (label4.Text != "")
            {   //burada tekrar  EBOB'a tıklanınca label4 yani sonuç textim boştan farklı ise 
                //label1'e cevabı gönderiyoruz çünkü çıkan sonuç üzerinden tekrar işlem 
                //yapmamıza izin veriyor.
                label1.Text =  cevap.ToString("F3");
                label3.Text = "";
            }
            if (label1.Text == "")
            {//label1 yani ilk sayi girilmemiş ise message kutusunun warning iconu ile 
                //kullanıcıya bilgilendirme mesajı veriyor.
                MessageBox.Show("İlk sayi girilmeden işlem girilemez.", "Dikkat!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                label2.Text = "";//label2 boş yapılıp,
                islem = true;//islem true olur ve label1 e tekrar yazmamızı sağlar.
                //kısacası ilk sayi girilmediyse bilgilendirme uyarısından sonra tekrar label 1 den başlatır.
            }
            label6.Visible = false;
            //label6.visible false yapma sebebim geçmişi göster dedikten sonra geçmiş gösterilir
            //daha sonrasında tekrar bir işlem yapılmak istendiğinde operatörlere basılınca geçmişi
            //tekrar gizliyor.daha sonrasında tekrar geçmiş butonuna basarak bütün geçmişi tekrar 
            //gösteriyor.
        }

        private void btnekok_Click(object sender, EventArgs e)
        {
            islem = false;//ilk sayi girilir ve ekoka basıldıktan sonra işlem false olur ki ikinci sayi girilsin.
            label2.Text = "EKOK";//label2.text ine Ekok Yazdirilir.
            secim = 'K'; //K Ekoku Simgeler;
            if (label4.Text != "")
            {
                //burada tekrar  EBOB'a tıklanınca label4 yani sonuç textim boştan farklı ise 
                //label1'e cevabı gönderiyoruz çünkü çıkan sonuç üzerinden tekrar işlem 
                //yapmamıza izin veriyor.
                label1.Text =  cevap.ToString("F3");
                label3.Text = "";
            }
            if (label1.Text == "")
            {
                //label1 yani ilk sayi girilmemiş ise message kutusunun warning iconu ile 
                //kullanıcıya bilgilendirme mesajı veriyor.
                MessageBox.Show("İlk sayi girilmeden işlem girilemez.", "Dikkat!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                label2.Text = "";//label2 boş yapılıp,
                islem = true;//islem true olur ve label1 e tekrar yazmamızı sağlar.
                //kısacası ilk sayi girilmediyse bilgilendirme uyarısından sonra tekrar label 1 den başlatır.
            }
            label6.Visible = false;
            //label6.visible false yapma sebebim geçmişi göster dedikten sonra geçmiş gösterilir
            //daha sonrasında tekrar bir işlem yapılmak istendiğinde operatörlere basılınca geçmişi
            //tekrar gizliyor.daha sonrasında tekrar geçmiş butonuna basarak bütün geçmişi tekrar 
            //gösteriyor.
        }

        private void btnmod_Click(object sender, EventArgs e)
        {


            islem = false;//ilk sayi girilir ve moda basıldıktan sonra işlem false olur ki ikinci sayi girilsin.
            label2.Text = "MOD";//label2.text ine MOD Yazdirilir.
            secim = 'M';// M Mod Almayı Simgeler;
            if (label4.Text != "")
            {
                //burada tekrar  EBOB'a tıklanınca label4 yani sonuç textim boştan farklı ise 
                //label1'e cevabı gönderiyoruz çünkü çıkan sonuç üzerinden tekrar işlem 
                //yapmamıza izin veriyor.
                label1.Text = cevap.ToString("F3");
                label3.Text = "";
            }
            if (label1.Text == "")
            {
                //label1 yani ilk sayi girilmemiş ise message kutusunun warning iconu ile 
                //kullanıcıya bilgilendirme mesajı veriyor.
                MessageBox.Show("İlk sayi girilmeden işlem girilemez.", "Dikkat!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                label2.Text = "";//label2 boş yapılıp,
                islem = true;//islem true olur ve label1 e tekrar yazmamızı sağlar.
                //kısacası ilk sayi girilmediyse bilgilendirme uyarısından sonra tekrar label 1 den başlatır.
            }
            label6.Visible = false;
            //label6.visible false yapma sebebim geçmişi göster dedikten sonra geçmiş gösterilir
            //daha sonrasında tekrar bir işlem yapılmak istendiğinde operatörlere basılınca geçmişi
            //tekrar gizliyor.daha sonrasında tekrar geçmiş butonuna basarak bütün geçmişi tekrar 
            //gösteriyor.


        }

        private void btnkarekok_Click(object sender, EventArgs e)
        {
            islem = false;//ilk sayi girilir ve Karekök simgesine basıldıktan sonra işlem false olur ki ikinci sayi girilsin.
            label2.Text = "√";//label2.text ine √ Yazdirilir.
            secim = 'S'; //S Karekök Almayı ifade eder;
            if (label4.Text != "")
            {
                //burada tekrar  EBOB'a tıklanınca label4 yani sonuç textim boştan farklı ise 
                //label1'e cevabı gönderiyoruz çünkü çıkan sonuç üzerinden tekrar işlem 
                //yapmamıza izin veriyor.
                label3.Text = cevap.ToString();
                label1.Text = "";
            }
            if (label1.Text == "")
            {

                //Eğer Direkt Köklü ifade yazılacaksa label1 i 1 de 

                label1.Text = "1";

                islem = false;//label3 e geçiş yap.
            }

            label6.Visible = false;
            //label6.visible false yapma sebebim geçmişi göster dedikten sonra geçmiş gösterilir
            //daha sonrasında tekrar bir işlem yapılmak istendiğinde operatörlere basılınca geçmişi
            //tekrar gizliyor.daha sonrasında tekrar geçmiş butonuna basarak bütün geçmişi tekrar 
            //gösteriyor.
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            //Butona Basılınca label 6 yani geçmiş listem gösterilir.Yukarıda da operatörlere tekrar 
            //tıklanınca geçmiş gizletilir.Daha sonra işlemler yapılır ve tekrar göster butonuna tıklanınca
            //Yapılan Bütün Geçmiş İşlemleri Gösterir.

        }
    }



}

