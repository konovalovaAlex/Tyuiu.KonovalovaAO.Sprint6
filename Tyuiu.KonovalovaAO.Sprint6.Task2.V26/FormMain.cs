using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KonovalovaAO.Sprint6.Task2.V26.Lib;
namespace Tyuiu.KonovalovaAO.Sprint6.Task2.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
      
        private void buttonDone_KAO_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KAO.Text);
                int stopStep = Convert.ToInt32(textBoxKonec_KAO.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult_KAO.Titles.Add("График функции");

                this.chartResult_KAO.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_KAO.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_KAO.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartResult_KAO.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonDone_KAO_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void buttonDone_KAO_Enter(object sender, EventArgs e)
        {
            buttonDone_KAO.BackColor = Color.Red;
        }

        private void buttonDone_KAO_Leave(object sender, EventArgs e)
        {
            buttonDone_KAO.BackColor = Color.Green;
        }

        private void buttonDone_KAO_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KAO.BackColor = Color.Blue;
        }

        private void buttonSpravka_KAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы СМАРТб-23-1 Коновалова Александра Олеговна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
