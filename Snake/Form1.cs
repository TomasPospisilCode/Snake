using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class Formulář : Form
    {
        private List<Kruh> Had = new List<Kruh>();
        private Kruh jídlo = new Kruh();

        public Formulář()
        {

            InitializeComponent();

            //Nastavení na výchozí
            new Nastavení();

            //Nastaví rychlost hry a spustí časovač
            herniCasovac.Interval = 1000 / Nastavení.Rychlost;
            herniCasovac.Tick += ObnoveníObrazovky;
            herniCasovac.Start();

            //Spustí novou hru
            SpustitHru();
        }

        private void SpustitHru()
        {
            lblKonecHry.Visible = false;

            //Nastavení na výchozí
            new Nastavení();

            //Vytvoří nového hráče
            Had.Clear();
            Kruh hlava = new Kruh { X = 10, Y = 5 };
            Had.Add(hlava);


            lblSkore.Text = Nastavení.Skóre.ToString();
            GenerovatJídlo();

        }

        //Náhodné umístění jídla
        private void GenerovatJídlo()
        {
            int maxXPoz = pbPozadi.Size.Width / Nastavení.Šířka;
            int maxYPoz = pbPozadi.Size.Height / Nastavení.Výška;

            Random náhoda = new Random();
            jídlo = new Kruh { X = náhoda.Next(0, maxXPoz), Y = náhoda.Next(0, maxYPoz) };
        }

        private void ObnoveníObrazovky(object sender, EventArgs e)
        {

            //Zkontroluje, jestli hra neskončila
            if (Nastavení.KonecHry)
            {
                //Kontrola, zda je stisklá klávesa "ENTER"
                if (Vstup.StisknutaKlavesa(Keys.Enter))
                {
                    SpustitHru();
                }
                
            }
            else
            {
                if (Vstup.StisknutaKlavesa(Keys.Right) && Nastavení.směr != Směr.Doleva)
                    Nastavení.směr = Směr.Doprava;
                else if (Vstup.StisknutaKlavesa(Keys.Left) && Nastavení.směr != Směr.Doprava)
                    Nastavení.směr = Směr.Doleva;
                else if (Vstup.StisknutaKlavesa(Keys.Up) && Nastavení.směr != Směr.Dolů)
                    Nastavení.směr = Směr.Nahoru;
                else if (Vstup.StisknutaKlavesa(Keys.Down) && Nastavení.směr != Směr.Nahoru)
                    Nastavení.směr = Směr.Dolů;

                PohybHráče();
            }

            pbPozadi.Invalidate();
        }

        private void pbPozadi_Click(object sender, EventArgs e)
        {

        }

        private void pbPozadi_Paint(object sender, PaintEventArgs e)
        {
            Graphics pozadi = e.Graphics;

            if (!Nastavení.KonecHry)
            {
                //Nastaví barvu hada

                //Nakreslí hada
                for (int i = 0; i < Had.Count; i++)
                {
                    Brush barvaHada;
                    if (i == 0)
                        barvaHada = Brushes.Black;     //Nakreslí hlavu
                    else
                        barvaHada = Brushes.Green;    //Zbytek těla

                    //Nakreslí hada
                    pozadi.FillEllipse(barvaHada,
                        new Rectangle(Had[i].X * Nastavení.Šířka,
                                      Had[i].Y * Nastavení.Výška,
                                      Nastavení.Šířka, Nastavení.Výška));


                    //Nakresli jídlo
                    pozadi.FillEllipse(Brushes.Red,
                        new Rectangle(jídlo.X * Nastavení.Šířka,
                             jídlo.Y * Nastavení.Výška, Nastavení.Šířka, Nastavení.Výška));

                }
            }
            else
            {
                string konecHry = "Konec hry \nVaše konečné skóre je: " + Nastavení.Skóre + "\nPro novou hru stiskněte ENTER";
                lblKonecHry.Text = konecHry;
                lblKonecHry.Visible = true;
            }
        }
        private void PohybHráče()
        {
            for (int i = Had.Count - 1; i >= 0; i--)
            {
                //Pohyb hlavy
                if (i == 0)
                {
                    switch (Nastavení.směr)
                    {
                        case Směr.Doprava:
                            Had[i].X++;
                            break;
                        case Směr.Doleva:
                            Had[i].X--;
                            break;
                        case Směr.Nahoru:
                            Had[i].Y--;
                            break;
                        case Směr.Dolů:
                            Had[i].Y++;
                            break;
                    }


                    //Získat nejvyšší možnou X a Y pozici
                    int maxXPoz = pbPozadi.Size.Width / Nastavení.Šířka;
                    int maxYPoz = pbPozadi.Size.Height / Nastavení.Výška;

                    //Detekce kolize s okrajem
                    if (Had[i].X < 0 || Had[i].Y < 0
                        || Had[i].X >= maxXPoz || Had[i].Y >= maxYPoz)
                    {
                        Zemřít();
                    }


                    //Detekce kolize s tělem
                    for (int j = 1; j < Had.Count; j++)
                    {
                        if (Had[i].X == Had[j].X &&
                           Had[i].Y == Had[j].Y)
                        {
                            Zemřít();
                        }
                    }

                    //Detekce kolize s jídlem
                    if (Had[0].X == jídlo.X && Had[0].Y == jídlo.Y)
                    {
                        Jíst();
                    }

                }
                else
                {
                    //Pohyb těla
                    Had[i].X = Had[i - 1].X;
                    Had[i].Y = Had[i - 1].Y;
                }
            }
        }

         private void Jíst()
        {
            //Přidá k tělu kruh
            Kruh kruh = new Kruh
            {
                X = Had[Had.Count - 1].X,
                Y = Had[Had.Count - 1].Y
            };
            Had.Add(kruh);

            //Aktualizzuje skóre
            Nastavení.Skóre += Nastavení.Body;
            lblSkore.Text = Nastavení.Skóre.ToString();

            GenerovatJídlo();
        }

        private void Zemřít()
        {
            Nastavení.KonecHry = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Vstup.ZměnaStavu(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
               Vstup.ZměnaStavu(e.KeyCode, false);
        }

        private void nápovědaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Help.ShowHelp(this, "..\\..\\..\\Had nápověda\\Had nápověda.chm");
        }

    }
}
