using System;
using System.Drawing;
using System.Windows.Forms;
using CeasarCipherLib;
using StencilLib;
using RailFenceCipherLib;
using TurningGrilleLib;

namespace VisualInteface
{
    public partial class Form1 : Form
    {

        private Stencil stencil = new Stencil();
        public Form1()
        {
            InitializeComponent();
        }


        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e) //перезаписывает галочку  
        {
            for (int i = 0; i < ListCiphers.Items.Count; i++)
            {
                if (e.Index != i)
                {
                    ListCiphers.SetItemChecked(i, false);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.Add(stencil);
            numericUpDown1_ValueChanged(sender, e);
            stencil.MultiSelect = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            stencil.DeleteAllColRows();
            stencil.AddColRows((int)this.rankEdit.Value);
            stencil.FillWhite();
            stencil.MultiSelect = false;
        }

        private void setStencilButton_Click(object sender, EventArgs e) //устанавливает решётку
        {
            stencil.FillWhite();
            var numStencil = new Stensil();
            numStencil.SetMatrixStensil((int)rankEdit.Value);
            stencil.SetHoles(numStencil);
        }

        private void cipherButton_Click(object sender, EventArgs e) //шифрует в соответствии с установленными значениями
        {
            if (ListCiphers.SelectedIndex == 0 && inputTextEdit.Text != "")
            {
                var ceasarCipher = new CeasarCipher();
                string cipherWord = "";
                ceasarCipher.EncryptWord((int)ceasarEdit.Value, inputTextEdit.Text, ref cipherWord);
                outputTextEdit.Text = cipherWord;
            }

            if (ListCiphers.SelectedIndex == 1 && columnarEdit.Text != "" && inputTextEdit.Text != "")
            {
                var colCipher = new ColumnarCipherLib.ColumnarEncryptionMethod();
                string cipherWord = "";
                colCipher.EncryptWord(columnarEdit.Text, inputTextEdit.Text, ref cipherWord);
                outputTextEdit.Text = cipherWord;
            }

            if (ListCiphers.SelectedIndex == 2 && inputTextEdit.Text != "")
            {
                var railCipher = new RailFenceCipher();
                string cipherWord = "";
                railCipher.EncryptWord((int)railEdit.Value, inputTextEdit.Text, ref cipherWord);
                outputTextEdit.Text = cipherWord;
            }

            bool isFill = false;
            for (int i = 0; i < stencil.Rows.Count; i++)  //проверяем, заполено ли решето
            {
                for (int j = 0; j < stencil.Columns.Count; j++)
                {
                    if (stencil[i, j].Style.BackColor == Color.Black)
                        isFill = true;
                }
            }

            if (ListCiphers.SelectedIndex == 3 && inputTextEdit.Text != "" && isFill)
            {
                var grillCipher = new TurningGrille();
                string cipherWord = "";
                int[,] numStensil;
                numStensil = stencil.TranslateToNumMatrix();
                grillCipher.EncryptWord(numStensil, inputTextEdit.Text, ref cipherWord);
                outputTextEdit.Text = cipherWord;
            }
        }

        private void decipherButton_Click(object sender, EventArgs e) //дешифрует в соответствии с установленными значениями
        {
            if (ListCiphers.SelectedIndex == 0 && inputTextEdit.Text != "")
            {
                var ceasarCipher = new CeasarCipher();
                string decipherWord = "";
                ceasarCipher.DecryptWord((int)ceasarEdit.Value, inputTextEdit.Text, ref decipherWord);
                outputTextEdit.Text = decipherWord;
            }

            if (ListCiphers.SelectedIndex == 1 && columnarEdit.Text != "" && inputTextEdit.Text != "")
            {
                var colCipher = new ColumnarCipherLib.ColumnarEncryptionMethod();
                string decipherWord = "";
                colCipher.DecryptWord(columnarEdit.Text, inputTextEdit.Text, ref decipherWord);
                outputTextEdit.Text = decipherWord;
            }

            if (ListCiphers.SelectedIndex == 2 && inputTextEdit.Text != "")
            {
                var railCipher = new RailFenceCipher();
                string decipherWord = "";
                railCipher.DecryptWord((int)railEdit.Value, inputTextEdit.Text, ref decipherWord);
                outputTextEdit.Text = decipherWord;
            }

            if (ListCiphers.SelectedIndex == 3 && inputTextEdit.Text != "")
            {
                var grillCipher = new TurningGrille();
                string decipherWord = "";
                int[,] numStensil;
                numStensil = stencil.TranslateToNumMatrix();
                grillCipher.DecryptWord(numStensil, inputTextEdit.Text, ref decipherWord);
                outputTextEdit.Text = decipherWord;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}