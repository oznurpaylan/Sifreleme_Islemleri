using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //hash algoritmalarını kullanabilmek için kütüphane

namespace sifreleme_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //RIPEMD160 algoritmasının sonucu sha1 ile aynıdır. 
        public string SHA1Hash(string input)
        {
            SHA1 sha1Hasher = SHA1.Create();
            byte[] data = sha1Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder(); 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static string SHA256(string plaintext)
        {
            using (var sha256provider = new SHA256CryptoServiceProvider())
            {
                var hash = sha256provider.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }

        //Facebook hash algoritması olarak sha384 algoritmasını kullanır.
        public static string SHA384(string plaintext)
        {
            using (var sha384provider = new SHA384CryptoServiceProvider())
            {
                var hash = sha384provider.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }
       
        public static string SHA512(string plaintext)
        {
            using (var sha512provider = new SHA512CryptoServiceProvider())
            {
                var hash = sha512provider.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }

        public static string MD5(string plaintext)
        {
            using (var mdp5provider = new MD5CryptoServiceProvider())
            {
                var hash = mdp5provider.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }

        private void sifrele_Click(object sender, EventArgs e)
        {
            if (sifrelenecekMetin.Text == "")
            {
                MessageBox.Show("LUTFEN ŞİFRELENECEK BİR METİN GİRİNİZ...");

            }
            else if (algoSec.SelectedItem == null)
            {
                MessageBox.Show("LÜTFEN BİR ŞİFRELEME ALGORİTMASI SEÇİNİZ...");
            }
            else
            {
                sifreliMetin.Visible = true;
                algoMetin.Visible = true;
 
                switch (algoSec.SelectedIndex)
                {
                    case 0:
                        algoMetin.Text = "sha1 algoritması ile çevrilen metin: ";
                        sifreliMetin.Text = SHA1Hash(sifrelenecekMetin.Text);
                        break;

                    case 1:
                        algoMetin.Text = "SHA256 algoritması ile çevrilen metin: ";
                        sifreliMetin.Text = SHA256(sifrelenecekMetin.Text);
                        break;

                    case 2:
                        algoMetin.Text = "SHA384 algoritması ile çevrilen metin: ";
                        sifreliMetin.Text = SHA384(sifrelenecekMetin.Text);
                        break;

                    case 3:
                        algoMetin.Text = "SHA512 algoritması ile çevrilen metin: ";
                        sifreliMetin.Text = SHA512(sifrelenecekMetin.Text);
                        break;

                    case 4:
                        algoMetin.Text = "MD5 algoritması ile çevrilen metin: ";
                        sifreliMetin.Text = MD5(sifrelenecekMetin.Text);
                        break;

                    default:
                        MessageBox.Show("MEVCUT ALGORİTMA İNDEXİ BULUNAMADI....");
                        break;
                }
            }
        }
    }
}
