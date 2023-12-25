using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using Tyuiu.RagimovaMA.Sprint7.V5.Lib;

namespace Tyuiu.RagimovaMA.Sprint7.V5
{
    public partial class FormMain_RMA : Form
    {
        public FormMain_RMA()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void buttonForUser_RMA_Click(object sender, EventArgs e)
        {
            FormForUser_RMA formForUser = new FormForUser_RMA();
            formForUser.ShowDialog();
        }

        private void buttonAboutProg_RMA_Click(object sender, EventArgs e)
        {
            FormAboutProg_RMA formAboutProg = new FormAboutProg_RMA();
            formAboutProg.ShowDialog();
        }

        private void buttonOpenFile_RMA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_RMA.ShowDialog();
                openFilePath = openFileDialog_RMA.FileName;

                string[,] matrix = ds.LoadFromFileData(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewMatrix_RMA.RowCount = rows + 1;
                dataGridViewMatrix_RMA.ColumnCount = columns;

                //добавление данных
                for (int i = 1; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix_RMA.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewMatrix_RMA.AutoResizeColumns();
                dataGridViewMatrix_RMA.ScrollBars = ScrollBars.Both;
                buttonSaveFile_RMA.Enabled = true;
                buttonAdd_RMA.Enabled = true;
                buttonDel_RMA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_RMA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_RMA.FileName = ".csv";
                saveFileDialog_RMA.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog_RMA.ShowDialog();

                string path = saveFileDialog_RMA.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewMatrix_RMA.RowCount;
                int columns = dataGridViewMatrix_RMA.ColumnCount;

                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewMatrix_RMA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewMatrix_RMA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.Default);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_RMA_Click(object sender, EventArgs e)
        {
            string Articule_SAN = textBoxCodAdd_RMA.Text;
            string name_SAN = textBoxNameAdd_RMA.Text;
            string CountSklad_SAN = textBoxScladAdd_RMA.Text;
            string postavshik_SAN = textBoxPriceAdd_RMA.Text;
            string price_SAN = textBoxPostavAdd_RMA.Text;

            // заполнение
            dataGridViewMatrix_RMA.Rows.Add(Articule_SAN, name_SAN, CountSklad_SAN, postavshik_SAN, price_SAN);
            textBoxCodAdd_RMA.Text = "";
            textBoxNameAdd_RMA.Text = "";
            textBoxScladAdd_RMA.Text = "";
            textBoxPriceAdd_RMA.Text = "";
            textBoxPostavAdd_RMA.Text = "";
            dataGridViewMatrix_RMA.CurrentCell = dataGridViewMatrix_RMA.Rows[dataGridViewMatrix_RMA.Rows.Count - 1].Cells[0];
        }

        private void buttonDel_RMA_Click(object sender, EventArgs e)
        {
            if (dataGridViewMatrix_RMA.RowCount != 0)
            {
                int del = 0;
                var result = MessageBox.Show($"{"Удалить данную строку?\rЕё невозможно будет восстановить"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    del = 1;
                }
                if (del == 1)
                {
                    int a = dataGridViewMatrix_RMA.CurrentCell.RowIndex;
                    dataGridViewMatrix_RMA.Rows.RemoveAt(a);
                }
            }
            else
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonForUser_RMA_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonForUser_RMA_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonAboutProg_RMA_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonAboutProg_RMA_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonOpenFile_RMA_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonAdd_RMA_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonOpenFile_RMA_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonAdd_RMA_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonSaveFile_RMA_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonSaveFile_RMA_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonDel_RMA_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonDel_RMA_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonSearch_RMA_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch_RMA.Text;

            foreach (DataGridViewRow row in dataGridViewMatrix_RMA.Rows)
            {
                bool found = false;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if(cell.Value != null && cell.Value.ToString().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }
                if(found)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void buttonSum_RMA_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridViewMatrix_RMA.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridViewMatrix_RMA.Rows[i].Cells[2].Value);
            }
            textBoxSumSclad_RMA.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridViewMatrix_RMA.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridViewMatrix_RMA.Rows[i].Cells[3].Value);
            }
            textBoxSumPrice_RMA.Text = sum.ToString();
        }

        private void buttonDone_RMA_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = dataGridViewMatrix_RMA.RowCount;
                int columns = dataGridViewMatrix_RMA.ColumnCount;
                string str;
                string[,] matrix = new string[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        str = "";
                        str += dataGridViewMatrix_RMA.Rows[i].Cells[j].Value;
                        matrix[i, j] = str;
                    }

                }

                int sump = 0;
                int suma = 0;
                int sumg = 0;
                int sumc = 0;
                for (int i = 0; i < rows - 1; i++)
                {
                    if (matrix[i, 1] == "Гирлянда")
                    {
                        sump += Convert.ToInt32(dataGridViewMatrix_RMA.Rows[i].Cells[2].Value);
                    }
                    if (matrix[i, 1] == "Скотч")
                    {
                        suma += Convert.ToInt32(dataGridViewMatrix_RMA.Rows[i].Cells[2].Value);
                    }
                    if (matrix[i, 1] == "Карандаши цветные")
                    {
                        sumg += Convert.ToInt32(dataGridViewMatrix_RMA.Rows[i].Cells[2].Value);
                    }
                    if (matrix[i, 1] == "Кружка")
                    {
                        sumc += Convert.ToInt32(dataGridViewMatrix_RMA.Rows[i].Cells[2].Value);
                    }
                }
                textBoxPng_RMA.Text = sump.ToString();
                textBoxApple_RMA.Text = suma.ToString();
                textBoxGru_RMA.Text = sumg.ToString();
                textBoxCup_RMA.Text = sumc.ToString();


                string[] seriesArray = { "Гирлянда", "Скотч", "Карандаши цветные", "Кружка" };
                int[] pointsArray = { sump, suma, sumg, sumc };

                this.chart_RMA.Palette = ChartColorPalette.Fire;

                this.chart_RMA.Titles.Add("Количество");

                for (int i = 0; i < seriesArray.Length; i++)
                {
                    Series series = this.chart_RMA.Series.Add(seriesArray[i]);

                    series.Points.Add(pointsArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Невозможно повторно построить график", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPriceAdd_RMA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}