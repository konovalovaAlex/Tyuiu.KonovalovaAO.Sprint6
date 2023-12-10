using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KonovalovaAO.Sprint6.Task4.V25.Lib;
using System.IO;
namespace Tyuiu.KonovalovaAO.Sprint6.Task4.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonNote_KAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы СМАРТб-23-1 Коновалова Александра Олеговна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KAO_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_KAO.Text);
                int stop = Convert.ToInt32(textBoxStop_KAO.Text);
                
                int len = ds.GetMassFunction(start, stop).Length;
                
                double[] array = ds.GetMassFunction(start, stop);

                textBoxResult_KAO.Text = "";
                chartResult_KAO.Series[0].Points.Clear();
                this.chartResult_KAO.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_KAO.ChartAreas[0].AxisY.Title = "Ось y";

                for (int i = 0; i < len; i++)
                {
                    textBoxResult_KAO.AppendText(Convert.ToString(array[i]) + Environment.NewLine);
                    chartResult_KAO.Series[0].Points.AddXY(start, array[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_KAO_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V25.txt";
                File.WriteAllText(path, textBoxResult_KAO.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + "сохранен успешно!\n Открыть его в блокноте ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранение файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
