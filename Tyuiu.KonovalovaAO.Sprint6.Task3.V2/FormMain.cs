using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KonovalovaAO.Sprint6.Task3.V2.Lib;
namespace Tyuiu.KonovalovaAO.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -12, -4, -20, 5, -5 },
                                        { 2, 15, 1, -20, 7 },
                                        { 15, -15, 2, 11, 5 },
                                        { -19, -9, 16, 0, 1 },
                                        { 17, 16, 5, 12, -8 } };
        private void labelUslovi_KAO_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_KAO.RowCount = rows;
            dataGridViewMatrix_KAO.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KAO.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    
                    dataGridViewMatrix_KAO.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_KAO_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int coll = res.Length / rows;
            dataGridViewMatrisa_KAO.ColumnCount = coll;
            dataGridViewMatrisa_KAO.RowCount = rows;
            for (int i = 0; i < coll; i++)
            {
                dataGridViewMatrisa_KAO.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    dataGridViewMatrisa_KAO.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }

        }

        private void buttonSpravka_KAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы СМАРТб-23-1 Коновалова Александра Олеговна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
