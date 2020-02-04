using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Josip_Petanjek_C2.Kriptiranje
{
    class RSA
    {
        public static string JavniKljuc { get; set; }
        public static string PrivatniKljuc { get; set; }
        private static RSACryptoServiceProvider RSAalgoritam;
        private static RSAParameters Parametri;

        public static string PretvorbaByteUString(byte[] poljeBajtova)
        {
            return Convert.ToBase64String(poljeBajtova);
        }

        public static void Kljucevi ()
        {
            RSAalgoritam = new RSACryptoServiceProvider(2048);
            Parametri = RSAalgoritam.ExportParameters(true);

            JavniKljuc = PretvorbaByteUString(Parametri.Modulus);
            PrivatniKljuc = PretvorbaByteUString(Parametri.D);

            File.WriteAllText(Datoteke.JavniKljuc, JavniKljuc);
            File.WriteAllText(Datoteke.PrivatniKljuc, PrivatniKljuc);
        }

        public static byte[] RSAKriptiranje(byte[] znakoviZaKriptiranje)
        {
            byte[] kriptirano = RSAalgoritam.Encrypt(znakoviZaKriptiranje, false);
            return kriptirano;
        }

        public static string RSADekriptiranje(byte[] kriptiranaDatoteka)
        {
            byte[] dekriptirano = RSAalgoritam.Decrypt(kriptiranaDatoteka, false);
            return Encoding.UTF8.GetString(dekriptirano);
        }

        public static byte[] RacunajSazetak(byte[] datoteka)
        {
            SHA256Managed sha256 = new SHA256Managed();
            sha256.ComputeHash(datoteka, 0, datoteka.Length);

            return sha256.Hash;
        }

        public static byte[] DigitalniPotpis(byte[] datoteka)
        {
            byte[] sazetak = RacunajSazetak(datoteka);
            byte[] digitalniPotpis = RSAalgoritam.SignHash(sazetak, CryptoConfig.MapNameToOID("SHA256"));

            return digitalniPotpis;
        }

        public static bool ProvjeraDigitalnogPotpisa(byte[] datoteka, byte[] digitalniPotpis)
        {
            return RSAalgoritam.VerifyHash(RacunajSazetak(datoteka), CryptoConfig.MapNameToOID("SHA256"), digitalniPotpis);
        }

    }
}
