using System.Windows.Forms;

namespace StencilLib
{
    public class Stencil : DataGridView
    {
        public Stencil()
        {
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            BorderStyle = BorderStyle.None;
            ColumnHeadersVisible = false;
            Location = new System.Drawing.Point(510, 180);
            Name = "Stencil";
            RowHeadersVisible = false;
            RowTemplate.Height = 30;
            RowTemplate.ReadOnly = true;
            RowTemplate.Resizable = DataGridViewTriState.False;
            SelectionMode = DataGridViewSelectionMode.CellSelect;
            Size = new System.Drawing.Size(205, 205);
            TabIndex = 14;
        }

        public void FillWhite()
        {
            for (int i = 0; i < Rows.Count; i++)   // сбрасываем цвет ячеек на белый
            {
                for (int j = 0; j < Columns.Count; j++)
                {
                    this[i, j].Style.BackColor = System.Drawing.Color.White;
                }
            }
        }

        public void SetHoles(TurningGrilleLib.Stensil stencil)
        {
            for (int i = 0; i < Rows.Count; i++)
            {
                for (int j = 0; j < Columns.Count; j++)
                {
                    if (stencil.Value[i, j] == 1)
                    {
                        this[i, j].Style.BackColor = System.Drawing.Color.Black;
                    }
                }
            }
        }

        public void DeleteAllColRows()
        {
            string name;
            for (int i = 0; i < Columns.Count; i++) // delete columns
            {
                name = Columns[i].Name;
                Columns.Remove(name);
            }

            int n = Rows.Count;
            for (int i = 1; i < n; i++) // delete rows
            {
                Rows.RemoveAt(0);
            }
        }

        public void AddColRows(int rank)
        {
            string nameCol = "Col ";
            int num = 1;
            for (int i = Columns.Count; i < rank; i++) // add columns 
            {
                Columns.Add(nameCol + num.ToString(), "");
                Columns[i].Resizable = DataGridViewTriState.False;
                Columns[i].Width = 30;
                num++;
            }

            for (int i = Rows.Count; i < rank; i++) // add rows
            {
                Rows.Add();
            }
        }

        public int[,] TranslateToNumMatrix()
        {
            int[,] matrix = new int[Rows.Count, Columns.Count];
            for (int i = 0; i < Rows.Count; i++)  //TODO выбыриаем распложение прорезей в соотв. с gui решеткой
            {
                for (int j = 0; j < Columns.Count; j++)
                {
                    if (this[i, j].Style.BackColor == System.Drawing.Color.Black)
                    {
                        matrix[j, i] = 1;
                    }
                }
            }

            return matrix;
        }
    }
}