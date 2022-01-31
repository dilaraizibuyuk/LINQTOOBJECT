using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQTOOBJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Urunler = new List<Urun>();
            Urun u = new Urun();
            u.urunadi = "Yiyecek";
            Kategori kat01 = new Kategori() { KategoriID = 1, KategoriAdi = "Meyveler" };
            Kategori kat02 = new Kategori() { KategoriID = 2, KategoriAdi = "Sebzeler" };
            Urunler.Add(new Urun()
            {
                urunID = 1,
                urunadi = "Elma",
                kategori = kat01,
                fiyat = 3.45m,
                stok = 250
            });
            Urunler.Add(new Urun()
            {
                urunID = 2,
                urunadi = "Kiraz",
                kategori = kat01,
                fiyat = 2.30m,
                stok = 300
            });
            Urunler.Add(new Urun()
            {
                urunID = 3,
                urunadi = "Kabak",
                kategori = kat02,
                fiyat = 5.45m,
                stok = 150
            });
            Urunler.Add(new Urun()
            {
                urunID = 4,
                urunadi = "Patlıcan",
                kategori = kat01,
                fiyat = 1.50m,
                stok = 500
            });

        }
        List<Urun> Urunler;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Urun> Secilenler = new List<Urun>();
            foreach (Urun item in Urunler)
            {
                if (item.fiyat>3)
                {
                    Secilenler.Add(item);
                }
            }
            dataGridView1.DataSource = Secilenler;
        }
    }
}
