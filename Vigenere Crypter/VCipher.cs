using System;
using System.Text;

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
        public string VigenereEncrypt(string toEncode, string key)
        {
            // Create and instanciate var to return the encoded msg
            string encoded = null;
            // Create and instanciate var to encode the message
            char[,] cipher = new char[26,26];
            // Fill the cipher array with letters
            cipher = FillEncrypter(cipher);
            // Var for incrementation of key, message, and full encoded word
            int keyIndex = 0, msgIndex = 0, wrdIndex = 0;
            // Encode every letter of the word
            for (int i = 0; i < toEncode.Length; i++)
            {
                // If the key is finished, go back at the beginning of it
                if (wrdIndex >= key.Length)
                    wrdIndex = 0;
                // Find the associated letter with the keyword
                msgIndex = (key[keyIndex] - 65);
                keyIndex++;
                // Find the associated letter with the msg to encode
                wrdIndex = (toEncode[i] - 65);
                encoded += cipher[keyIndex, wrdIndex];
            } // Return the encoded message to the event
            return encoded;
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

        #region Char[,] converter
        // Method to fill the encrypter with characters
        char[,] FillEncrypter(char[,] encrypter)
        {
            // Fill horizontal (fictive) line with alphabets
            for (int horizontal = 0; horizontal < 26; horizontal++)
            {
                // Fill vertical (fictive) line with alphabets
                for (int vertical = 0; vertical < 26; vertical++)
                {
                    // While character > 'A' and character < 'Z', fill
                    int character = 65 + horizontal + vertical;
                    if (character >= 91) // If character == 'Z'
                        character = character - 26; // Fill encrypter with characters
                    encrypter[horizontal, vertical] = (char)(character);
                }
            } // Return the encrypter, full of characters
            return encrypter;
        }
        #endregion Char[,] converter
    }
}
