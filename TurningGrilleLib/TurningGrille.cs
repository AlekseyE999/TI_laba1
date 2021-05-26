using System;

namespace TurningGrilleLib
{
    public class Stensil
    {
        private int[,] value;

        internal void ResetMiddleElem(int key) //убирает прорезь в решетке
        {
            if (key % 2 == 1)
            {
                var middleInd = key / 2;
                value[middleInd, middleInd] = 0;
            }
        }

        internal void SetMiddleElem(int key) //добавляет прорезь в решетке
        {
            if (key % 2 == 1)
            {
                var middleInd = key / 2;
                value[middleInd, middleInd] = 1;
            }
        }

        internal void TurnRightStensil()
        {
            void CopyMatrix(int[,] source, ref int[,] reciev)
            {
                var s = (int)Math.Sqrt(source.Length);
                for (var i = 0; i < s; i++)
                    for (var j = 0; j < s; j++)
                        reciev[i, j] = source[i, j];
            }

            var len = (int)Math.Sqrt(value.Length);
            var tempMatrix = new int[len, len];
            var index = len - 1;
            for (var i = 0; i < len; i++)
            {
                for (var j = 0; j < len; j++)
                    if (value[i, j] != 0 && tempMatrix[j, index] == 0)
                        tempMatrix[j, index] = value[i, j];
                index--;
            }

            CopyMatrix(tempMatrix, ref value);
        }

        private int[] FindEmptyPosition(int len) //ищет не занятый элемент в матрице
        {
            for (var i = 0; i < len; i++)
                for (var j = 0; j < len; j++)
                    if (value[i, j] == 0)
                    {
                        var arr = new[] { i, j };
                        return arr;
                    }

            return null;
        }

        public void SetMatrixStensil(int key)
        {
            value = new int[key, key];
            var arrIndex = new int[2];
            int num = 1, ind = 1, randomRow, randomCol;
            while (arrIndex != null) //заполняет матрицу цифрами
            {
                for (var k = 0; k < 4; k++)
                {
                    value[arrIndex[0], arrIndex[1]] = num;
                    TurnRightStensil();
                }

                arrIndex = FindEmptyPosition(key);
                num++;
            }

            var rnd = new Random();
            while (ind != num) //выбирает прорези в матрице
            {
                randomRow = rnd.Next() % key;
                randomCol = rnd.Next() % key;
                if (value[randomCol, randomRow] == ind)
                {
                    value[randomCol, randomRow] = -1;
                    ind++;
                }
            }

            for (var i = 0; i < key; i++) //зануляет ненужные элементы
                for (var j = 0; j < key; j++)
                    if (value[i, j] != -1)
                        value[i, j] = 0;
                    else
                        value[i, j] = Math.Abs(value[i, j]);
        }

        public int[,] Value 
        {
            get => value;
            set => this.value = value;
        }
    }

    public class TurningGrille
    {
        public void EncryptWord(int[,] key, string plainText, ref string cipherText)
        {
            plainText = plainText.Replace(" ", "");
            if (plainText.Length % key.Length != 0) //дополняем строку доп. символами
            {
                var count = key.Length > plainText.Length
                    ? key.Length - plainText.Length
                    : key.Length - plainText.Length % key.Length;
                for (var i = 0; i < count; i++) plainText += "$";
            }

            var matrixStencil = new Stensil();
            matrixStencil.Value = key;
            var rank = (int)Math.Sqrt(key.Length);
            var cipherMatrix = new char[rank, rank];
            var index = 0;
            while (index < plainText.Length)
            {
                for (var i = 0; i < rank; i++) //обнуление матрицы 
                    for (var j = 0; j < rank; j++)
                        cipherMatrix[i, j] = '\0';
                matrixStencil.SetMiddleElem(rank);

                for (var i = 0; i < 4; i++) //заполняем матрицу с символами через решетку
                {
                    for (var j = 0; j < rank; j++)
                        for (var k = 0; k < rank; k++)
                            if (matrixStencil.Value[j, k] == 1 && index < plainText.Length)
                            {
                                cipherMatrix[j, k] = plainText[index];
                                index++;
                            }

                    matrixStencil.TurnRightStensil();
                    matrixStencil.ResetMiddleElem(rank);
                }

                for (var i = 0; i < rank; i++)
                    for (var j = 0; j < rank; j++)
                        if (cipherMatrix[i, j] != '\0')
                            cipherText += cipherMatrix[i, j];
            }
        }

        public void DecryptWord(int[,] key, string cipherText, ref string plainText)
        {
            cipherText = cipherText.Replace(" ", "");
            var matrixStencil = new Stensil();
            matrixStencil.Value = key;
            var rank = (int)Math.Sqrt(key.Length);
            var cipherMatrix = new char[rank, rank];
            var index = 0;
            while (index < cipherText.Length)
            {
                for (var i = 0; i < rank; i++) //заполняем матрицу символами
                    for (var j = 0; j < rank; j++)
                        if (index < cipherText.Length)
                        {
                            cipherMatrix[i, j] = cipherText[index];
                            index++;
                        }

                for (var i = 0; i < 4; i++) //считываем символы из матрицы в соответсвии с трафаретом 
                {
                    for (var j = 0; j < rank; j++)
                        for (var k = 0; k < rank; k++)
                            if (matrixStencil.Value[j, k] == 1)
                                if (cipherMatrix[j, k] != '\0')
                                    plainText += cipherMatrix[j, k];

                    var middleElem = rank / 2;
                    if (rank % 2 == 1)
                        cipherMatrix[middleElem, middleElem] = '\0';
                    matrixStencil.TurnRightStensil();
                }

                for (var i = 0; i < rank; i++) //обнуление матрицы 
                    for (var j = 0; j < rank; j++)
                        cipherMatrix[i, j] = '\0';

                plainText = plainText.Replace("$", "");
            }
        }
    }
}