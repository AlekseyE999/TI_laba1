namespace ColumnarCipherLib
{
    public class ColumnarEncryptionMethod
    {
        private readonly struct CipherStruct //структура хранящая ключ цифры и символы исходного слова
        {
            private readonly char[] key;
            private readonly int[] nums;

            public CipherStruct(string key) //структура хранит ключ цифры и символы шифруемого слова 
            {
                var len = key.Length;
                this.key = new char[len];
                this.key = key.ToCharArray();
                nums = new int[len];
            }

            public void PutNumbers() //расставляет цифры в соответствии с алфавитом
            {
                int len = key.Length, prior;
                for (var j = 0; j < len; j++)
                {
                    prior = 1;
                    for (var k = 0; k < len; k++)
                    {
                        if (k < j && key[k] <= key[j]) prior++;
                        if (k > j && key[k] < key[j]) prior++;
                    }

                    nums[j] = prior;
                }
            }

            public int[] GetNums()
            {
                return nums;
            }

            public int GetNumRow(string origWord) //возвращает число строк для шифруемого слова
            {
                var numRows = origWord.Length / key.Length;
                if (origWord.Length % key.Length != 0)
                    numRows++;
                return numRows;
            }
        }

        public void EncryptWord(string key, string origWord, ref string encryptedWord)
        {
            var word = origWord.Replace(" ", "");
            var myCipherStruct = new CipherStruct(key);
            myCipherStruct.PutNumbers();
            int lenWord = word.Length, ind = 0;
            var numRows = myCipherStruct.GetNumRow(word);
            var arrChars = new char[numRows, key.Length];
            for (var i = 0; i < numRows; i++)  //расставляем символы в массиве
                for (var j = 0; j < key.Length; j++)
                {
                    arrChars[i, j] = word[ind];
                    ind++;
                    if (ind > lenWord - 1)
                        break;
                }

            ind = 1;
            for (var i = 0; i < key.Length; i++)
                for (var j = 0; j < key.Length; j++)
                    if (ind == myCipherStruct.GetNums()[j])
                    {
                        for (var k = 0; k < numRows; k++)
                            if (arrChars[k, j] != '\0')
                                encryptedWord += arrChars[k, j];
                        ind++;
                    }
        }

        public void DecryptWord(string key, string origWord, ref string decryptedWord)
        {
            var word = origWord.Replace(" ", "");
            var myCipherStruct = new CipherStruct(key);
            myCipherStruct.PutNumbers();
            int lenKey = key.Length, lenWord = word.Length;
            int numRows = myCipherStruct.GetNumRow(word), num = 1, index = 0;
            var arrChars = new char[numRows, lenKey];
            for (var i = 0; i < lenKey; i++) //расставляем символы в соответсвии с цифрами
                for (var j = 0; j < lenKey; j++)
                    if (num == myCipherStruct.GetNums()[j])
                    {
                        for (var k = 0; k < numRows; k++)
                            if (k * lenKey + j < lenWord)
                            {
                                arrChars[k, j] = word[index];
                                index++;
                            }

                        num++;
                    }

            for (var i = 0; i < numRows; i++) //последоватлеьно читаем массив char
                for (var j = 0; j < lenKey; j++)
                {
                    decryptedWord += arrChars[i, j];
                    if (i * lenKey + j >= lenWord - 1)
                        break;
                }
        }
    }
}