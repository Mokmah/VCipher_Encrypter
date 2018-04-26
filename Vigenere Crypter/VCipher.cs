using System;
using System.Text;

/// <summary>
/// Vigenere encryption and decryption functions
/// By William Garneau
/// 
/// The Vigenère cipher is a method of encrypting alphabetic
/// text by using a series of different Caesar ciphers based
/// on the letters of a keyword. It is a simple form of
/// polyalphabetic substitution. 
/// </summary>
/// 
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
    }
}
