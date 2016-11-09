using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inl2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            using (var db = new KundContext())
            {
                var kund1 = new Kund()
                {
                    KundId = 1,
                    Föramn = "Philip",
                    Efternamn = "Wallin",
                    Telefonnummer = "0704944006",
                    Email = "philipwallin@live.se",
                    Adress = "Midskeppsgatan 16",
                };
                var kund2 = new Kund()
                {
                    KundId = 2,
                    Föramn = "Kalle",
                    Efternamn = "Andersson",
                    Telefonnummer = "0704944011",
                    Email = "kalleandersson@live.se",
                    Adress = "Midskeppsgatan 15",
                };
                var kund3 = new Kund()
                {
                    KundId = 3,
                    Föramn = "John",
                    Efternamn = "Doe",
                    Telefonnummer = "087020090",
                    Email = "johndoe@live.se",
                    Adress = "Midskeppsgatan 14",
                };
                var kund4 = new Kund()
                {
                    KundId = 4,
                    Föramn = "jane",
                    Efternamn = "doe",
                    Telefonnummer = "08414006",
                    Email = "janedoe@live.se",
                    Adress = "Midskeppsgatan 14",
                };
                var jeans = new Kategori()
                {
                    KategoriId = 1,
                    Typ = "Jeans"
                };
                var skor = new Kategori()
                {
                    KategoriId = 2,
                    Typ = "Skor"
                };
                var tshirt = new Kategori()
                {
                    KategoriId = 3,
                    Typ = "Tshirt"
                };

            }         
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
