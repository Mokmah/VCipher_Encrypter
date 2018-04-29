using System;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// Vigenere Crypter
/// By William Garneau
/// 
/// Data encryption and decryption using 
/// Vigenère Cipher Method
/// *** Key is needed to encrypt/decrypt a msg *** 
/// </summary>
namespace Vigenere_Crypter
{
    public partial class CipherForm : Form
    {
        VCipher cipher;
        public CipherForm()
        {
            InitializeComponent();
            cipher = new VCipher();
        }

        #region Events
        private void btnEncode_Click(object sender, EventArgs e)
        {
            // Var for containing the new encoded message
            string msgEncoded;
            try
            { // We can't have an empty string when encoding
                if (String.IsNullOrEmpty(txtKey.Text))
                {
                    MessageBox.Show("Vous devez entrer entrer une clé pour être en mesure d'encrypter le message !", "Erreur d'entrée", MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    txtKey.Focus();
                }
                else
                {   // Remove spaces in msg to encode
                    string msg = txtEncode.Text.ToUpper().Replace(" ", string.Empty);
                    // Var for encoding the msg
                    StringBuilder sb = new StringBuilder(msg);
                    // Encoding the msg with key
                    VCipher.VigenereEncrypt(ref sb, txtKey.Text);
                    // Display the new coded msg
                    txtDecode.Text = sb.ToString();
                }
            }
            catch
            {
                MessageBox.Show("L'encryptage n'a pas fonctionné !", "Il y a eu une erreur ...", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                // We need a key to decode
                if (String.IsNullOrEmpty(txtKey.Text))
                {
                    MessageBox.Show("Vous devez entrer entrer une clé pour être en mesure d'encrypter le message !", "Erreur d'entrée", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtKey.Focus();
                }
                else
                {   // Remove spaces in msg to decode
                    string msg = txtEncode.Text.Replace(" ", string.Empty);
                    // Var for decoding the msg
                    StringBuilder sb = new StringBuilder(msg);
                    // Get the real message with key
                    VCipher.VigenereDecrypt(ref sb, txtKey.Text);
                    // Display the msg
                    txtDecode.Text = sb.ToString();
                }
            }
            catch
            {
                MessageBox.Show("L'encryptage n'a pas fonctionné !", "Il y a eu une erreur ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion Events
    }
}
