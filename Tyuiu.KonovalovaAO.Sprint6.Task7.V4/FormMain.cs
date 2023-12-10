using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KonovalovaAO.Sprint6.Task7.V4.Lib;
namespace Tyuiu.KonovalovaAO.Sprint6.Task7.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_KAO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_KAO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";

        }
        static string openFile;
        static int rows;
        static int columns;

        DataService ds = new DataService();

        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonInfo_KAO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_KAO_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAO.ShowDialog();
            openFile = openFileDialogTask_KAO.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInput_KAO.RowCount = rows;
            dataGridViewInput_KAO.ColumnCount = columns;
            dataGridViewOutput_KAO.RowCount = rows;
            dataGridViewOutput_KAO.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_KAO.Columns[i].Width = 50;
                dataGridViewOutput_KAO.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_KAO.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_KAO.Enabled = true;
        }

        private void buttonDone_KAO_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_KAO.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_KAO.Enabled = true;
        }

        private void buttonSave_KAO_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KAO.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KAO.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KAO.ShowDialog();

            string path = saveFileDialogMatrix_KAO.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_KAO.RowCount;
            int columns = dataGridViewOutput_KAO.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutput_KAO.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutput_KAO.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_KAO.RowCount = 50;
            dataGridViewOutput_KAO.RowCount = 50;

            dataGridViewInput_KAO.ColumnCount = 50;
            dataGridViewOutput_KAO.ColumnCount = 50;



            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_KAO.Columns[i].Width = 25;
                dataGridViewOutput_KAO.Columns[i].Width = 25;
            }
        }

        private void buttonOpenFile_KAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAO.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_DED_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAO.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_DED_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAO.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_DED_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAO.ToolTipTitle = "Справка";
        }


    }


}
