using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere_Crypter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Events
        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtKey.Text))
                {
                    MessageBox.Show("Vous devez entrer entrer une clé pour être en mesure d'encrypter le message !", "Erreur d'entrée", MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    txtKey.Focus();
                }
                else
                {
                    StringBuilder sb = new StringBuilder(txtEncode.Text);
                    VCipher.VigenereEncrypt(ref sb, txtKey.Text);
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
                if (String.IsNullOrEmpty(txtKey.Text))
                {
                    MessageBox.Show("Vous devez entrer entrer une clé pour être en mesure d'encrypter le message !", "Erreur d'entrée", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtKey.Focus();
                }
                else
                {
                    StringBuilder sb = new StringBuilder(txtEncode.Text);
                    VCipher.VigenereDecrypt(ref sb, txtKey.Text);
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
