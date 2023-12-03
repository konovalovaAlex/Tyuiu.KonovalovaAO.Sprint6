using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint6.Task0.V5.Lib;
using System.Windows.Forms;
namespace Tyuiu.KonovalovaAO.Sprint6.Task0.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDonne_KAO_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult_KAO.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_KAO.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVopros_KAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы СМАРТб-23-1 Коновалова Александра Олеговна", "Сообщение");
        }

        private void textBoxInput_KAO_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxInput_KAO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

        }
    }
}
