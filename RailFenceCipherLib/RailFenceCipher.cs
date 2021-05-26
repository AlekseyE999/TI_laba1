using System;

namespace RailFenceCipherLib
{
    public class RailFenceCipher
    {
        public void EncryptWord(int key, string origWord, ref string encryptedWord)
        {
            var word = origWord.Replace(" ", "");
            var rows = new string[key];
            var period = 2 * (key - 1);
            for (var i = 0; i < key; i++) rows[i] = "";

            for (var i = 0; i < word.Length; i++)
            {
                var numRow = Math.Abs(-(i % period) + key - 1); //номер строки, в которую записывается символ
                rows[numRow] += word[i];
            }

            for (var i = rows.Length - 1; i >= 0; i--) encryptedWord += rows[i];
        }

        public void DecryptWord(int key, string origWord, ref string decryptedWord)
        {
            var word = origWord.Replace(" ", "");
            var rows = new char[key, word.Length];
            int i, j;
            for (i = 0; i < key; i++)
                for (j = 0; j < word.Length; j++)
                    rows[i, j] = '\0';
            int period = 2 * (key - 1), ind;
            var increase = false;
            j = i = 0;
            while (i < word.Length)
            {
                rows[j, i] = '1';
                ind = i % period;
                if (ind < key - 1)
                {
                    if (ind % (key - 1) == 0)
                        increase = false;
                }
                else
                {
                    if (ind % (key - 1) == 0)
                        increase = true;
                }

                i++;
                if (!increase)
                    j++;
                else
                    j--;
            }

            var numLetter = 0;
            for (i = 0; i < key; i++) //заполняем матрицу символами
                for (j = 0; j < word.Length; j++)
                    if (rows[i, j] == '1')
                    {
                        rows[i, j] = word[numLetter];
                        numLetter++;
                    }

            for (var k = 0; k < word.Length; k++) //читаем слово
                for (var l = 0; l < key; l++)
                    if (rows[l, k] != '\0')
                        decryptedWord += rows[l, k];
        }
    }
}