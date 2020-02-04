using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Josip_Petanjek_C2
{
    class Datoteke
    {
        public static string Direktorij { get; set; }
        public static string Datoteka { get; set; }
        public static string DigitalniPotpis { get; set; }
        public static string Sazetak { get; set; }
        public static string RSAKriptirani { get; set; }
        public static string AESKriptirani { get; set; }
        public static string JavniKljuc { get; set; }
        public static string PrivatniKljuc { get; set; }
        public static string TajniKljuc { get; set; }

        public static void ObrisiSve()
        {
            if(File.Exists(DigitalniPotpis)&& File.Exists(Sazetak) && File.Exists(RSAKriptirani) && File.Exists(AESKriptirani) && File.Exists(JavniKljuc) && File.Exists(PrivatniKljuc) && File.Exists(TajniKljuc))
            {
                File.Delete(DigitalniPotpis);
                File.Delete(Sazetak);
                File.Delete(RSAKriptirani);
                File.Delete(AESKriptirani);
                File.Delete(JavniKljuc);
                File.Delete(PrivatniKljuc);
                File.Delete(TajniKljuc);
            }
            
        }

        public static bool OdabirDirektorija()
        {
            FolderBrowserDialog DirektorijDialog = new FolderBrowserDialog();
            if (DirektorijDialog.ShowDialog() == DialogResult.OK)
            {
                Direktorij = DirektorijDialog.SelectedPath;
                DigitalniPotpis = Direktorij + @"\digitalniPotpis.txt";
                Sazetak = Direktorij + @"\sazetak.txt";
                RSAKriptirani = Direktorij + @"\RSAKriptiraniTekst.txt";
                AESKriptirani = Direktorij + @"\AESKriptiraniTekst.txt";
                JavniKljuc = Direktorij + @"\javni_kljuc.txt";
                PrivatniKljuc = Direktorij + @"\privatni_kljuc.txt";
                TajniKljuc = Direktorij + @"\tajni_kljuc.txt";

                return true;
            }
            else
                Direktorij = "";
            return false;
        }

        

        public static void StvoriDatotekeZaKljuceve()
        {
            if (!File.Exists(JavniKljuc) || !File.Exists(PrivatniKljuc) || !File.Exists(TajniKljuc))
            {
                File.Create(JavniKljuc).Close();
                File.Create(PrivatniKljuc).Close();
                File.Create(TajniKljuc).Close();

                Kriptiranje.RSA.Kljucevi();
                Kriptiranje.AES.Kljucevi();
            }
            else
            {
                MessageBox.Show("Datoteke zamijenjene");
                Kriptiranje.RSA.JavniKljuc = Kriptiranje.RSA.PretvorbaByteUString( Datoteke.Citaj(JavniKljuc));
                Kriptiranje.RSA.PrivatniKljuc = Kriptiranje.RSA.PretvorbaByteUString(Datoteke.Citaj(PrivatniKljuc));
                Kriptiranje.AES.TajniKljuc = Kriptiranje.RSA.PretvorbaByteUString(Datoteke.Citaj(TajniKljuc));
            }

        }

        internal static void Zapisi(string unos)
        {
            if(Datoteka != null)
            {
                File.WriteAllText(Datoteka, unos);
            }
            else
            {
                Datoteka = Direktorij + @"\Input.txt";
                File.Create(Datoteka).Close();
            }
        }

        public static bool OdaberiDatoteku()
        {
            OpenFileDialog odabirDatoteke = new OpenFileDialog();

            if (odabirDatoteke.ShowDialog() == DialogResult.OK)
            {
                Datoteka = odabirDatoteke.FileName;
                return true;
            }
            else
                MessageBox.Show("Datoteka nije odabrana");

            return false;
        }

        public static byte[] Citaj(string putanja)
        {
            byte[] vratiByteDatoteke = null;

            if (putanja != null)
            {
                vratiByteDatoteke = Encoding.UTF8.GetBytes(File.ReadAllText(putanja));
            }

            return vratiByteDatoteke;
        }

        
    }
}
