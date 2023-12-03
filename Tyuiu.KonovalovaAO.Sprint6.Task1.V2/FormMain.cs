using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KonovalovaAO.Sprint6.Task1.V2.Lib;
namespace Tyuiu.KonovalovaAO.Sprint6.Task1.V2
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

                int startValue = int.Parse(textBoxStart_KAO.Text);
                int stopValue = int.Parse(textBoxKonec_KAO.Text);

                double[] array = ds.GetMassFunction(startValue, stopValue);

                string str = null;
                textBoxResult_KAO.AppendText("+-----------+------------+" + "\r\n");
                textBoxResult_KAO.AppendText("|     X     |    f(x)    |" + "\r\n");
                textBoxResult_KAO.AppendText("+-----------+------------+" + "\r\n");
                for (global::System.Int32 i = 0; i < array.Length; i++)
                {
                    str = string.Format("|{0,6}     |  {1, 6}    |", startValue, array[i]);
                    textBoxResult_KAO.AppendText(str + "\r\n");
                    startValue++;
                }
                textBoxResult_KAO.AppendText("+-----------+------------+" + "\r\n");
            }

            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_KAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Варинт 2 выполнила студентка СМАРТб-23-1 Коновалова Александра Олеговна", "Информация о студенте", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
