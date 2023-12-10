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
using Tyuiu.KonovalovaAO.Sprint6.Task6.V3.Lib;
namespace Tyuiu.KonovalovaAO.Sprint6.Task6.V3
{
    public partial class FormMain : Form
    {
        

        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_KAO_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAO.ShowDialog();
            openFilePath = openFileDialogTask_KAO.FileName;
            textBoxInPutData_KAO.Text = File.ReadAllText(openFilePath);
            groupBoxInPutData_KAO.Text = groupBoxInPutData_KAO.Text + " " + openFileDialogTask_KAO.FileName;
            buttonDone_KAO.Enabled = true;
            buttonDone_KAO.BackColor = Color.LimeGreen;
        }

        private void buttonDone_KAO_Click(object sender, EventArgs e)
        {
            textBoxOutPutData_KAO.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_KAO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
