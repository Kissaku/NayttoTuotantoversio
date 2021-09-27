using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhjelmaTuotantoverio
{
    public partial class Form1 : Form
    {

        int painovoima = 15;
        int vihollisNopeus = 8;
        int pisteet = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pelinAjastinTapahtuma(object sender, EventArgs e)
        {
            Pelaaja.Top += painovoima;
            Vihollinen1.Left -= vihollisNopeus;
            Vihollinen2.Left -= vihollisNopeus;
            Vihollinen3.Left -= vihollisNopeus;
            pisteTeksti.Text = pisteet.ToString();

            if (Vihollinen1.Left < -160)
            {
                Vihollinen1.Left = 1880;
                pisteet++;
            }
            if (Vihollinen2.Left < -180)
            {
                Vihollinen2.Left = 1930;
                pisteet++;
            }
            if (Vihollinen3.Left < -150)
            {
                Vihollinen3.Left = 1900;
                pisteet++;
            }

            if (Pelaaja.Bounds.IntersectsWith(Vihollinen1.Bounds) ||
                Pelaaja.Bounds.IntersectsWith(Vihollinen2.Bounds) ||
                Pelaaja.Bounds.IntersectsWith(Vihollinen3.Bounds)
                )
            {
                peliLoppu();
            }

            if (pisteet > 5)
            {
                vihollisNopeus = 15;
            }

            if (pisteet > 10)
            {
                vihollisNopeus = 20;
            }

            if (pisteet > 20)
            {
                vihollisNopeus = 25;
            }

            if (pisteet > 30)
            {
                vihollisNopeus = 30;
            }

            if (pisteet > 40)
            {
                vihollisNopeus = 35;
            }

            if (Pelaaja.Top < -25)
            {
                peliLoppu();
            }

            if (Pelaaja.Top > 500)
            {
                peliLoppu();
            }
        }

        private void peliNappiAlas(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                painovoima = -15;
            }
        }

        private void peliNappiYlos(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                painovoima = 15;
            }
        }
        
        private void peliLoppu()
        {
            Ajastin.Stop();
            pisteTeksti.Text += " Game Over!!!";
            if (pisteet < 10)
            {
                Lopputeksti.Text = "Harvinaisen huonosti meni...";
            }
            if (pisteet > 15)
            {
                Lopputeksti.Text = "Sehän alkoi melkein rullaamaan!";
            }
            if (pisteet > 30)
            {
                Lopputeksti.Text = "Hyvä flow päällä sinulla!";
            }

        }
    }
}
