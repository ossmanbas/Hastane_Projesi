using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace berkayinprojesi
{
    public partial class Form1 : Form
    {
        Kisi Musteri1 = new Kisi();
        Kisi musteri2 = new();

        public Form1()
        {
            InitializeComponent();
            Musteri1.Ad = "Memati";
            Musteri1.Cinsiyet = "Erkek";
            Musteri1.KoltukNo = int.Parse(btn1.Text);
            musteri2.Ad = "Malsu";
            musteri2.Cinsiyet = "Kadın";
            musteri2.KoltukNo = int.Parse(btn2.Text);

        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            CinsiyetKontrol();
        }

        private void CinsiyetKontrol()
        {
            switch (Musteri1.Cinsiyet.ToLower())
            {
                case  "erkek" :
                    btn1.BackColor = Color.Blue;
                        break;
                case "kadın":
                    btn1.BackColor = Color.Pink;
                    break;

                default:
                    btn1.BackColor = Color.Gray;
                    break;
            }
            switch (musteri2.Cinsiyet.ToLower())
            {
                case "erkek":
                    btn2.BackColor = Color.Blue;
                    break;
                case "kadın":
                    btn2.BackColor = Color.Pink;
                    break;

                default:
                    btn2.BackColor = Color.Gray;
                    break;
            }

        }
    }
}
