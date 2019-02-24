using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            int i, w, liczba, w2 = 0, j;
            w = rtbdane.Lines.Count();
            int[] tablica1 = new int[w];
            w2 = 0;
            for (i = 0; i < w; i++)
            {
                bool b;
                b = int.TryParse(rtbdane.Lines[i], out liczba);
                if (b)
                {
                    tablica1[w2] = liczba;
                    w2++;
                }
            }
            foreach (int element2 in tablica1)
            {
                lsttab1.Items.Add(element2);

            }
            int[] tablica2 = new int[w2];
            for (i = 0; i < w2; i++)
            {
                tablica2[i] = tablica1[i];
            }
            foreach (int element2 in tablica2)
            {
                lsttab2.Items.Add(element2);
            }

            for (i = 0; i < w2 - 1; i++)
            {
                for (j = i + 1; j < w2; j++)
                {
                    if (tablica2[j] < tablica2[i])
                    {
                        int r = tablica2[i]; tablica2[i] = tablica2[j]; tablica2[j] = r;
                    }
                }
            }

            foreach (int element in tablica2)
            {
                lstwyn.Items.Add(element);

            }

        }

        private void btnczyt_Click(object sender, EventArgs e)
        {
            {

                int i, w, liczba, w2 = 0, j;
                w = rtbdane.Lines.Count();
                int[] tablica1 = new int[w];
                w2 = 0;

                for (i = 0; i < w; i++)
                {
                    bool b;
                    b = int.TryParse(rtbdane.Lines[i], out liczba);
                    if (b)
                    {
                        tablica1[w2] = liczba;
                        w2++;
                    }
                }

                foreach (int element2 in tablica1)
                {
                    lsttab1.Items.Add(element2);

                }
                int[] tablica2 = new int[w2];
                for (i = 0; i < w2; i++)
                {
                    tablica2[i] = tablica1[i];
                }
                foreach (int element2 in tablica2)
                {
                    lsttab2.Items.Add(element2);
                }

                for (i = 0; i < w2 - 1; i++)
                {
                    for (j = i + 1; j < w2; j++)
                    {
                        if (tablica2[j] > tablica2[i])
                        {
                            int r = tablica2[i]; tablica2[i] = tablica2[j]; tablica2[j] = r;
                        }
                    }
                }


                foreach (int element in tablica2)
                {
                    lstwyn.Items.Add(element);
                }
            }
        }

        private void czysc_Click(object sender, EventArgs e)
        {
            rtbdane.Clear();
            lstdane.Items.Clear();
            lstlis.Items.Clear();
            lsttab1.Items.Clear();
            lsttab2.Items.Clear();
            lstwyn.Items.Clear();
            lblsrednia.Text = "";

        }

        private void sumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, w, liczba, suma = 0;
            w = rtbdane.Lines.Count();
            int[] tablica1 = new int[w];
           

            for (i = 0; i < w; i++)
            {
                bool b;
                b = int.TryParse(rtbdane.Lines[i], out liczba);
                if (b)
                {
                    suma += liczba;
                }
                lblsuma.Text = System.Convert.ToString(suma);
            }
        }

        private void średniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, w, liczba, suma = 0, srednia, ilLiczb = 0;
            w = rtbdane.Lines.Count();
            int[] tablica1 = new int[w];
          

            for (i = 0; i < w; i++)
            {
                bool b;
                b = int.TryParse(rtbdane.Lines[i], out liczba);
                if (b)
                {
                    {
                        suma += liczba;
                        ilLiczb++;
                    }
                    srednia = suma / ilLiczb;
                    lblsrednia.Text = System.Convert.ToString(srednia);
                }
            }
        }

        private void iloścLiczbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, w, liczba, ilLiczb = 0;
            w = rtbdane.Lines.Count();
            int[] tablica1 = new int[w];
           

            for (i = 0; i < w; i++)
            {
                bool b;
                b = int.TryParse(rtbdane.Lines[i], out liczba);
                if (b)
                {
                    ilLiczb++;
                }
                lblliczby.Text = System.Convert.ToString(ilLiczb);
            }
        }

        private void liczWiekszeOdSrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, w, liczba, suma = 0, srednia = 0, ilLiczb = 0;
            w = rtbdane.Lines.Count();
             bool b;
            for (i = 0; i < w; i++)
            {
               
                b = int.TryParse(rtbdane.Lines[i], out liczba);
                if (b)
                {
                    {
                        suma += liczba;
                        ilLiczb++;
                        lstdane.Items.Add(liczba);

                    }
                    srednia = suma / ilLiczb;
                    lblsrednia.Text = System.Convert.ToString(srednia);
                }}
            // zapisanie danych do tablica1
               int[] tablica1 = new int[ilLiczb];
               for (i = 0; i < ilLiczb; i++)
               {
                   tablica1[i] = System.Convert.ToInt32(lstdane.Items[i]);
               }
            // wyswietlanie w oknie liczb wiekszych od sredniej arytmetycznych
                   foreach (int element3 in tablica1)
                   {
                       if (element3 > srednia)
                       {
                           lstlis.Items.Add(element3);
                       }
                   }
                
        }

        private void lstdane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wartośćMAXToolStripMenuItem_Click(object sender, EventArgs e)
       
     {
            int i, w, liczba, ilLiczb = 0, MAX = 0;
            w = rtbdane.Lines.Count();
            bool b;
           // wyswietlenie tylko liczb w oknie listbox z pominieciem liter

            for (i = 0; i < w; i++)
            {

                b = int.TryParse(rtbdane.Lines[i], out liczba);
                if (b)
                {
                    {
                        
                        ilLiczb++;
                        lstdane.Items.Add(liczba);
                        
                    }
                    
                }
            }
            // zapisanie danych do tablica1
               
               int[] tablica1 = new int[ilLiczb];
               for (i = 0; i < ilLiczb; i++)
               {
                   tablica1[i] = System.Convert.ToInt32(lstdane.Items[i]);
               }
            bool p = false;

            for (i = 0; i < ilLiczb; i++)
            {
                if (p == false)
                {
                    MAX = tablica1[0];
                    p = true;
                }
                else
                {
                    if (tablica1[i] > MAX)
                    {
                        MAX = tablica1[i];
                    }
                }
               lblmax.Text = MAX.ToString();
            }

            
        }

        private void wartośćMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, w, liczba, ilLiczb = 0, MIN = 0;
            w = rtbdane.Lines.Count();
            bool b;
            // wyswietlenie tylko liczb w oknie listbox z pominieciem liter

            for (i = 0; i < w; i++)
            {

                b = int.TryParse(rtbdane.Lines[i], out liczba);
                if (b)
                {
                    {

                        ilLiczb++;
                        lstdane.Items.Add(liczba);

                    }

                }
            }
            // zapisanie danych do tablica1

            int[] tablica1 = new int[ilLiczb];
            for (i = 0; i < ilLiczb; i++)
            {
                tablica1[i] = System.Convert.ToInt32(lstdane.Items[i]);
            }
            bool p = false;

            for (i = 0; i < ilLiczb; i++)
            {
                if (p == false)
                {
                    MIN = tablica1[0];
                    p = true;
                }
                else
                {
                    if (tablica1[i] < MIN)
                    {
                        MIN = tablica1[i];
                    }
                }
                lblmin.Text = MIN.ToString();
            }
        }
    }
}
