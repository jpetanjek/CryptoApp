using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Josip_Petanjek_C2.Kriptiranje
{
    class AES
    {

        public static Aes AES_var;
        public static string TajniKljuc;

        public static void Kljucevi()
        {
            AES_var = Aes.Create();
            AES_var.BlockSize = 128;
            AES_var.KeySize = 256;
            AES_var.Mode = CipherMode.CBC;
            AES_var.Padding = PaddingMode.PKCS7;

            AES_var.GenerateKey();
            AES_var.GenerateIV();

            File.WriteAllText(Datoteke.TajniKljuc, RSA.PretvorbaByteUString(AES_var.Key));
            TajniKljuc = RSA.PretvorbaByteUString(AES_var.Key);
        }

        public static byte[] AESKriptiranje(byte[] datotekaZaKriptiranje)
        {
            byte[] kriptirano;
            string tekstZaKriptiranje = Encoding.UTF8.GetString(datotekaZaKriptiranje);

            ICryptoTransform kriptator = AES_var.CreateEncryptor(AES_var.Key, AES_var.IV);

            using (MemoryStream msKriptator = new MemoryStream())
            {
                using (CryptoStream csKriptator = new CryptoStream(msKriptator, kriptator, CryptoStreamMode.Write))
                {
                    using (StreamWriter swKriptator = new StreamWriter(csKriptator))
                    {
                        swKriptator.Write(tekstZaKriptiranje);
                    }
                    kriptirano = msKriptator.ToArray();
                }
            }
            return kriptirano;
        }

        public static string AESDekriptiranje(byte[] kriptiraniTekst)
        {
            string dekriptiraniTekst = null;
            ICryptoTransform dekriptator = AES_var.CreateDecryptor(AES_var.Key, AES_var.IV);

            using (MemoryStream msDekriptator = new MemoryStream(kriptiraniTekst))
            {
                using (CryptoStream csDekriptator = new CryptoStream(msDekriptator, dekriptator, CryptoStreamMode.Read))
                {
                    using (StreamReader srDekriptator = new StreamReader(csDekriptator))
                    {
                        dekriptiraniTekst = srDekriptator.ReadToEnd();
                    }
                }
            }
            return dekriptiraniTekst;
        }
    }
}
