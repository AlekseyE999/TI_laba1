namespace CeasarCipherLib
{
    public class CeasarCipher
    {
        protected char GetCipherChar(int key, int symbolCode, int offset, int numLetters)
        {
            int relativeCode = symbolCode - offset;
            int newCode = (relativeCode + key) % numLetters;
            return System.Convert.ToChar(newCode + offset);
        }

        protected char GetDecipherChar(int key, int symbolCode, int offset, int numLetters)
        {
            int relativeCode = symbolCode - offset;
            int newCode = (relativeCode + numLetters - key) % numLetters;
            return System.Convert.ToChar(newCode + offset);
        }

        public void EncryptWord(int key, string plainText, ref string cipherText)
        {
            for (int i = 0; i < plainText.Length; i++)
            {
                int symbolCode = plainText[i];
                if (symbolCode >= 'a' && symbolCode <= 'z')
                {
                    cipherText += GetCipherChar(key, symbolCode, 'a', 26);
                }

                if (symbolCode >= 'A' && symbolCode <= 'Z')
                {
                    cipherText += GetCipherChar(key, symbolCode, 'A', 26);
                }

                if (symbolCode >= 'а' && symbolCode <= 'я' || symbolCode == 'ё')
                {
                    cipherText += GetCipherChar(key, symbolCode, 'а', 32);
                }

                if (symbolCode >= 'А' && symbolCode <= 'Я')
                {
                    cipherText += GetCipherChar(key, symbolCode, 'А', 32);
                }
            }
        }

        public void DecryptWord(int key, string ciphertext, ref string decipherText)
        {
            for (int i = 0; i < ciphertext.Length; i++)
            {
                int symbolCode = ciphertext[i];
                if (symbolCode >= 'a' && symbolCode <= 'z')
                {
                    decipherText += GetDecipherChar(key, symbolCode, 'a', 26);
                }

                if (symbolCode >= 'A' && symbolCode <= 'Z')
                {
                    decipherText += GetDecipherChar(key, symbolCode, 'A', 26);
                }

                if (symbolCode >= 'а' && symbolCode <= 'я' || symbolCode == 'ё')
                {
                    decipherText += GetDecipherChar(key, symbolCode, 'а', 32);
                }

                if (symbolCode >= 'А' && symbolCode <= 'Я')
                {
                    decipherText += GetDecipherChar(key, symbolCode, 'А', 32);
                }
            }
        }
    }
}