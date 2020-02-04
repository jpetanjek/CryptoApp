using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Josip_Petanjek_C2
{
    public partial class Glavni_izbornik : Form
    {
        bool direktorij = false;
        bool datoteka = false;
        public byte[] kriptiranoRSA;
        public byte[] kriptiranoAES;

        public Glavni_izbornik()
        {
            InitializeComponent();
        }

        private void Glavni_izbornik_Load(object sender, EventArgs e)
        {

        }

        private void Input_direktorija_Click(object sender, EventArgs e)
        {
            direktorij = Datoteke.OdabirDirektorija();

            if (direktorij)
            {
                try
                {
                    Datoteke.StvoriDatotekeZaKljuceve();

                    Input_datoteke.Enabled = true;
                    Input_teksta.Enabled = true;

                    Label_dir.Text = Datoteke.Direktorij;
                    Label_TK.Text=Kriptiranje.AES.TajniKljuc;
                    Label_PK.Text=Kriptiranje.RSA.PrivatniKljuc;
                    Label_JK.Text=Kriptiranje.RSA.JavniKljuc;
                }
                catch (Exception)
                {
                    throw new Exception("Datoteke za ključeve nisu kreirane");
                }
            }
            else
            {
                MessageBox.Show("Mapa nije odabrana");
                Input_datoteke.Enabled = false;
                Input_teksta.Enabled = false;
                if (datoteka)
                {
                    Onemoguci_Gumbe();
                }
            }
        }

        private void Input_datoteke_Click(object sender, EventArgs e)
        {
            datoteka = Datoteke.OdaberiDatoteku();
            if (datoteka)
            {
                UcitajTekstDatoteke();
                Omoguci_Gumbe();
            }
            else
            {
                Onemoguci_Gumbe();
            }
        }

        private void Input_teksta_TextChanged(object sender, EventArgs e)
        {
            if (Input_teksta.Text != "")
            {
                Datoteke.Zapisi(Input_teksta.Text);
                Omoguci_Gumbe();
            }
            else
            {
                Onemoguci_Gumbe();
            }
        }

        private void Onemoguci_Gumbe()
        {
            Input_AES_krip.Enabled = false;
            Input_RSA_krip.Enabled = false;
            Input_RSA_dekrip.Enabled = false;
            Input_AES_dekrip.Enabled = false;
            Input_provjeri.Enabled = false;
            Input_digitalni.Enabled = false;
            Input_sazetak.Enabled = false;
        }

        private void Omoguci_Gumbe()
        {
            Input_AES_krip.Enabled = true;
            Input_RSA_krip.Enabled = true;
            Input_RSA_dekrip.Enabled = true;
            Input_AES_dekrip.Enabled = true;
            Input_provjeri.Enabled = true;
            Input_digitalni.Enabled = true;
            Input_sazetak.Enabled = true;
        }

        private void UcitajTekstDatoteke()
        {
            Input_teksta.Clear();
            StreamReader citacTeksta = new StreamReader(Datoteke.Datoteka);
            String prvaLinija = "";
            prvaLinija = citacTeksta.ReadLine();
            if (String.IsNullOrEmpty(prvaLinija))
            {
                MessageBox.Show("Datoteka je prazna!");
                citacTeksta.Close();
            }
            else
            {
                while (prvaLinija != null)
                {
                    Input_teksta.Text += prvaLinija;
                    prvaLinija = citacTeksta.ReadLine();
                }
                citacTeksta.Close();
            }
        }

        private void Input_AES_krip_Click(object sender, EventArgs e)
        {
            byte[] byteDatoteke = Datoteke.Citaj(Datoteke.Datoteka);
            kriptiranoAES = null;

            if (byteDatoteke != null)
            {
                kriptiranoAES = Kriptiranje.AES.AESKriptiranje(byteDatoteke);
                File.WriteAllText(Datoteke.AESKriptirani, Kriptiranje.RSA.PretvorbaByteUString(kriptiranoAES));

                Output_kriptiranje.Text = Kriptiranje.RSA.PretvorbaByteUString(kriptiranoAES);
            }
            else
            {
                MessageBox.Show("Niste odabrali datoteku!");
            }

        }

        private void Input_RES_krip_Click(object sender, EventArgs e)
        {
            byte[] byteDatoteke = Datoteke.Citaj(Datoteke.Datoteka);
            kriptiranoRSA = null;

            if (byteDatoteke != null)
            {
                kriptiranoRSA = Kriptiranje.RSA.RSAKriptiranje(byteDatoteke);
                File.WriteAllText(Datoteke.RSAKriptirani, Kriptiranje.RSA.PretvorbaByteUString(kriptiranoRSA));

                Output_kriptiranje.Text = Kriptiranje.RSA.PretvorbaByteUString(kriptiranoRSA);
            }
            else
            {
                MessageBox.Show("Niste odabrali datoteku!");
            }
        }

        private void Input_AES_dekrip_Click(object sender, EventArgs e)
        {
            if (kriptiranoAES != null)
            {
                string dekriptiraniTekst = "";
                dekriptiraniTekst = Kriptiranje.AES.AESDekriptiranje(kriptiranoAES);
                Output_kriptiranje.Text = dekriptiraniTekst;
            }
            else
            {
                MessageBox.Show("Morate prvo kriptirati tekst!");
            }
        }

        private void Input_RSA_dekrip_Click(object sender, EventArgs e)
        {
            if (kriptiranoRSA != null)
            {
                string dekriptiraniTekst = "";
                dekriptiraniTekst = Kriptiranje.RSA.RSADekriptiranje(kriptiranoRSA);
                Output_kriptiranje.Text = dekriptiraniTekst;
            }
            else
            {
                MessageBox.Show("Morate prvo kriptirati tekst!");
            }
        }

        private void Input_sazetak_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Datoteke.Sazetak, Convert.ToBase64String(Kriptiranje.RSA.RacunajSazetak(Datoteke.Citaj(Datoteke.Datoteka))));
            Output_kriptiranje.Text = Convert.ToBase64String(Kriptiranje.RSA.RacunajSazetak(Datoteke.Citaj(Datoteke.Datoteka)));
        }

        private void Input_digitalni_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Datoteke.DigitalniPotpis, Convert.ToBase64String(Kriptiranje.RSA.DigitalniPotpis(Datoteke.Citaj(Datoteke.Datoteka))));
            Output_kriptiranje.Text = Convert.ToBase64String(Kriptiranje.RSA.DigitalniPotpis(Datoteke.Citaj(Datoteke.Datoteka)));
        }

        private void Input_provjeri_Click(object sender, EventArgs e)
        {
            if(Kriptiranje.RSA.ProvjeraDigitalnogPotpisa(Datoteke.Citaj(Datoteke.Datoteka), Convert.FromBase64String(File.ReadAllText(Datoteke.DigitalniPotpis))))
                MessageBox.Show("Valjan potpis");
            else
            {
            MessageBox.Show("Nije valjan");
            }
        }

        private void Glavni_izbornik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Datoteke.ObrisiSve();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
