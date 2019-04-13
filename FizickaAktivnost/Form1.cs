using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FizickaAktivnost.BusinessLogic;

namespace FizickaAktivnost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Osoba o = new Osoba("Pera","Peric",70);

            Trcanje t1 = new Trcanje(50, 8, o.kilogrami);


            Sklekovi s1 = new Sklekovi(8, 10, 1, o.kilogrami);
            
            Trcanje t2 = new Trcanje(70,7, o.kilogrami);

            Sklekovi s2 = s1;

            Grupa grupa1 = new Grupa();

            grupa1.dodaj(t1);
            grupa1.dodaj(t2);
            grupa1.dodaj(s1);
            grupa1.dodaj(s2);

           
            Osoba o2 = new Osoba("Pera", "Peric", 69);

            Trcanje t1O2 = new Trcanje(65, 8, o.kilogrami);

            Sklekovi s1O2 = new Sklekovi(8, 12, 1, o.kilogrami);

            Grupa grupa2 = new Grupa();

            grupa2.dodaj(t1O2);
            grupa2.dodaj(t1O2);

            grupa1.dodaj(grupa2);


            textBoxKalorija.Text = grupa1.brojKalorija().ToString();
            textBoxTrajanje.Text = grupa1.trajanje().ToString();
        }
    }
}
