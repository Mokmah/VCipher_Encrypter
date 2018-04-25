using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Vigenere encryption and decryption functions
/// By William Garneau
/// </summary>
namespace Vigenere_Crypter
{
    class VCipher
    {
        #region Vigenere Functions
        // Method to encrypt message with key
        public static void VigenereEncrypt(ref StringBuilder sb, string key)
        {
            // for each char in key, get in CAPS
            for (int i = 0; i < sb.Length; i++)
                sb[i] = Char.ToUpper(sb[i]);
            // Get key and put it in CAPS
            key = key.ToUpper();
            // Decrypt index var
            int index = 0;
            // Encrypt loop
            for (int i = 0; i < sb.Length; i++)
            {
                if (Char.IsLetter(sb[i]))
                {
                    sb[i] = (char)(sb[i] + key[index] - 'A');
                    if (sb[i] > 'Z')
                        sb[i] = (char)(sb[i] - 'Z' + 'A' - 1);
                }
                // Index incrementation while key isn't over
                index = index + 1 == key.Length ? 0 : index + 1;
            }
        }

        public static void VigenereDecrypt(ref StringBuilder sb, string key)
        {
            // for each char in key, get in CAPS
            for (int i = 0; i < sb.Length; i++)
                sb[i] = Char.ToUpper(sb[i]);
            // Get key and put it in CAPS
            key = key.ToUpper();
            // Decrypt index var
            int index = 0;
            // Decrypt loop
            for (int i = 0; i < sb.Length; i++)
            {
                if (Char.IsLetter(sb[i]))
                {
                    sb[i] = sb[i] >= key[index] ?
                        (char)(sb[i] - key[index] + 'A') :
                        (char)('A' + ('Z' - key[index] + sb[i] - 'A') + 1);
                }
                // Index incrementation while key isn't over
                index = index + 1 == key.Length ? 0 : index + 1;
            }
        }
        #endregion VigenereFunctions

        #region String Formatter
        public string Replace(string msg)
        {
            // Replace every unusual characters by correct ones in Ascii table
            string[] original = { "î", "Î", "ö", "Ö", "à", "À", "ê", "Ê", "ç", "Ç" };
            string[] converted = { "i", "I", "o", "O", "a", "A", "e", "E", "c", "C" };
            for (int i = 0; i < original.Length; i++)
            { 
                msg = msg.Replace(original[i], converted[i]);
            }
            return msg;
        }
        #endregion String Formatter
    }
}
