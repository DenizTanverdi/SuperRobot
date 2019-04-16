using SupRob.Images.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupRob
{
    public partial class Form1 : Form
    {
        int sayi1;
        int sayi2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            PictureBoxA.Image = Image.FromFile("C:/Users/DenizTanriverdi/Source/repos/SupRob/SupRob/Images/A Temiz.png");
            PictureBoxB.Image = Image.FromFile("C:/Users/DenizTanriverdi/Source/repos/SupRob/SupRob/Images/B Temiz.png");
            PictureBoxRob.Image = Image.FromFile("C:/Users/DenizTanriverdi/Source/repos/SupRob/SupRob/Images/Robot.jpg");
           
        }


       


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Proces processor = new Proces();
           
            Random rd = new Random();
            PictureBoxRob.Left -= rd.Next(0, 10);
            
            if (PictureBoxRob.Left <80)
            {
                timer1.Stop();
                if (sayi1 == 1)
                {
                    Processor proces = new Processor
                    {
                        Durum = "Kirli",
                        Islem = "Temizlendi",
                        RoomNameOne = "A Odası"
                    };
                    processor.AddProces(proces);
                }
                else
                {
                    Processor proces = new Processor
                    {
                        Durum = "Temiz",
                        Islem = "Sağa Geç",
                        RoomNameOne = "A Odası"
                    };
                    processor.AddProces(proces);
                }

                List<Processor> list = new List<Processor>();
                list = processor.GetAllProcesor();
                for (int i = 0; i < list.Count; i++)
                {
                    //string dosya_yolu = @"C:/Users/DenizTanriverdi/Desktop/robot.txt";
                    //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
                   // FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = File.AppendText("C:/Users/DenizTanriverdi/Desktop/robot.txt");
                   // StreamWriter sw = new StreamWriter(fs);
                    //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
                    sw.WriteLine(list[i].RoomNameOne + " " + list[i].Durum + " " + list[i].Islem);

                    //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
                    sw.Flush();
                    //Veriyi tampon bölgeden dosyaya aktardık.
                    sw.Close();
                    //fs.Close();
                }

                timer2.Start();

                //timer3.Start();
                PictureBoxA.Image = Image.FromFile("C:/Users/DenizTanriverdi/Source/repos/SupRob/SupRob/Images/A Temiz.png");




            }
           if(420<PictureBoxRob.Left && PictureBoxRob.Left < 424)
            {
                timer3.Start();

            }
           
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int sayi = rd.Next(2);
            if (sayi == 1) { timer2.Start(); }
            else
            {
                timer1.Start();
            }
            
            //MessageBox.Show(PictureBoxRob.Left.ToString());
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Proces processor = new Proces();
            Random rd = new Random();
            PictureBoxRob.Left += rd.Next(0, 10);
            if (PictureBoxRob.Left > 730)
            {
                timer2.Stop();
                if (sayi2 == 1)
                {
                    Processor proces = new Processor
                    {
                        Durum = "Kirli",
                        Islem = "Temizlendi",
                        RoomNameOne = "B Odası"
                    };
                    processor.AddProces(proces);
                }
                else
                {
                    Processor proces = new Processor
                    {
                        Durum = "Temiz",
                        Islem = "Sola Geç",
                        RoomNameOne = "B Odası"
                    };
                    processor.AddProces(proces);
                }

                List<Processor> list = new List<Processor>();
                list = processor.GetAllProcesor();
                for (int i = 0; i < list.Count; i++)
                {
                   // string dosya_yolu = @"C:/Users/DenizTanriverdi/Desktop/robot.txt";
                    //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
                   // FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = File.AppendText("C:/Users/DenizTanriverdi/Desktop/robot.txt");
                    //StreamWriter sw = new StreamWriter(fs);
                    //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
                    sw.WriteLine(list[i].RoomNameOne+" "+ list[i].Durum + " "+ list[i].Islem);
                    
                    //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
                    sw.Flush();
                    //Veriyi tampon bölgeden dosyaya aktardık.
                    sw.Close();
                    //fs.Close();
                }
                timer1.Start();
                
                PictureBoxB.Image = Image.FromFile("C:/Users/DenizTanriverdi/Source/repos/SupRob/SupRob/Images/B Temiz.png");
            }
            if (420 < PictureBoxRob.Left && PictureBoxRob.Left < 424)
            {
                timer3.Start();

            }

        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            sayi1 = rd.Next(2);
            sayi2 = rd.Next(2);
            
            if(sayi1==1 || sayi2 == 1)
            {
                timer3.Stop();
               // MessageBox.Show(sayi1 + "  " + sayi2);

            }
            if (sayi1 == 1)
            {
                PictureBoxA.Image = Image.FromFile("C:/Users/DenizTanriverdi/Source/repos/SupRob/SupRob/Images/A Kirli.png");
            }
            if (sayi2 == 1)
            {
                PictureBoxB.Image = Image.FromFile("C:/Users/DenizTanriverdi/Source/repos/SupRob/SupRob/Images/B kirli.png");
            }

        }
    }
}
