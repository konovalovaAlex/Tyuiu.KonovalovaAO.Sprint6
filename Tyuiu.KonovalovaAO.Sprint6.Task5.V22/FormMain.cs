using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KonovalovaAO.Sprint6.Task5.V22.Lib;
namespace Tyuiu.KonovalovaAO.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V22.txt";

        private void buttonDone_KAO_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KAO.ColumnCount = 2;
            dataGridViewResult_KAO.Columns[0].Width = 20;
            dataGridViewResult_KAO.Columns[1].Width = 50;

            this.chartResult_KAO.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_KAO.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_KAO.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_KAO.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_KAO.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_KAO_Click(object sender, EventArgs e)
        {
            
           try
            {
                string path = @"C:\DataSprint6\InPutFileTask5V22.txt";
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void buttonInfo_KAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы СМАРТб-23-1 Коновалова Александра Олеговна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
