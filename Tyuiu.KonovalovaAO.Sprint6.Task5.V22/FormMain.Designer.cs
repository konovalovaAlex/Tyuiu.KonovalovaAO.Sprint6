
namespace Tyuiu.KonovalovaAO.Sprint6.Task5.V22
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxUslo = new System.Windows.Forms.GroupBox();
            this.chartResult_KAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxVvod = new System.Windows.Forms.GroupBox();
            this.buttonInfo_KAO = new System.Windows.Forms.Button();
            this.buttonOpenFile_KAO = new System.Windows.Forms.Button();
            this.buttonDone_KAO = new System.Windows.Forms.Button();
            this.dataGridViewResult_KAO = new System.Windows.Forms.DataGridView();
            this.labelUslo_KAO = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxUslo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAO)).BeginInit();
            this.groupBoxVvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDone_KAO);
            this.panel1.Controls.Add(this.buttonInfo_KAO);
            this.panel1.Controls.Add(this.buttonOpenFile_KAO);
            this.panel1.Controls.Add(this.groupBoxVvod);
            this.panel1.Controls.Add(this.groupBoxUslo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 531);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxUslo
            // 
            this.groupBoxUslo.Controls.Add(this.labelUslo_KAO);
            this.groupBoxUslo.Location = new System.Drawing.Point(12, 13);
            this.groupBoxUslo.Name = "groupBoxUslo";
            this.groupBoxUslo.Size = new System.Drawing.Size(563, 84);
            this.groupBoxUslo.TabIndex = 0;
            this.groupBoxUslo.TabStop = false;
            this.groupBoxUslo.Text = "Условие";
            // 
            // chartResult_KAO
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult_KAO.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartResult_KAO.Legends.Add(legend4);
            this.chartResult_KAO.Location = new System.Drawing.Point(188, 15);
            this.chartResult_KAO.Name = "chartResult_KAO";
            this.chartResult_KAO.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartResult_KAO.Series.Add(series4);
            this.chartResult_KAO.Size = new System.Drawing.Size(765, 390);
            this.chartResult_KAO.TabIndex = 1;
            this.chartResult_KAO.Text = "chart1";
            // 
            // groupBoxVvod
            // 
            this.groupBoxVvod.Controls.Add(this.dataGridViewResult_KAO);
            this.groupBoxVvod.Controls.Add(this.chartResult_KAO);
            this.groupBoxVvod.Location = new System.Drawing.Point(12, 103);
            this.groupBoxVvod.Name = "groupBoxVvod";
            this.groupBoxVvod.Size = new System.Drawing.Size(956, 411);
            this.groupBoxVvod.TabIndex = 1;
            this.groupBoxVvod.TabStop = false;
            this.groupBoxVvod.Text = "Вывод данных";
            // 
            // buttonInfo_KAO
            // 
            this.buttonInfo_KAO.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonInfo_KAO.Location = new System.Drawing.Point(843, 13);
            this.buttonInfo_KAO.Name = "buttonInfo_KAO";
            this.buttonInfo_KAO.Size = new System.Drawing.Size(125, 84);
            this.buttonInfo_KAO.TabIndex = 3;
            this.buttonInfo_KAO.Text = "Справка";
            this.buttonInfo_KAO.UseVisualStyleBackColor = false;
            this.buttonInfo_KAO.Click += new System.EventHandler(this.buttonInfo_KAO_Click);
            // 
            // buttonOpenFile_KAO
            // 
            this.buttonOpenFile_KAO.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOpenFile_KAO.Location = new System.Drawing.Point(712, 13);
            this.buttonOpenFile_KAO.Name = "buttonOpenFile_KAO";
            this.buttonOpenFile_KAO.Size = new System.Drawing.Size(125, 84);
            this.buttonOpenFile_KAO.TabIndex = 4;
            this.buttonOpenFile_KAO.Text = "Сохранить файл";
            this.buttonOpenFile_KAO.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KAO.Click += new System.EventHandler(this.buttonOpenFile_KAO_Click);
            // 
            // buttonDone_KAO
            // 
            this.buttonDone_KAO.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonDone_KAO.Location = new System.Drawing.Point(581, 12);
            this.buttonDone_KAO.Name = "buttonDone_KAO";
            this.buttonDone_KAO.Size = new System.Drawing.Size(125, 84);
            this.buttonDone_KAO.TabIndex = 5;
            this.buttonDone_KAO.Text = "Выполнить";
            this.buttonDone_KAO.UseVisualStyleBackColor = false;
            this.buttonDone_KAO.Click += new System.EventHandler(this.buttonDone_KAO_Click);
            // 
            // dataGridViewResult_KAO
            // 
            this.dataGridViewResult_KAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KAO.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewResult_KAO.Name = "dataGridViewResult_KAO";
            this.dataGridViewResult_KAO.RowHeadersWidth = 51;
            this.dataGridViewResult_KAO.RowTemplate.Height = 24;
            this.dataGridViewResult_KAO.Size = new System.Drawing.Size(172, 383);
            this.dataGridViewResult_KAO.TabIndex = 2;
            // 
            // labelUslo_KAO
            // 
            this.labelUslo_KAO.AutoSize = true;
            this.labelUslo_KAO.Location = new System.Drawing.Point(9, 22);
            this.labelUslo_KAO.Name = "labelUslo_KAO";
            this.labelUslo_KAO.Size = new System.Drawing.Size(506, 34);
            this.labelUslo_KAO.TabIndex = 0;
            this.labelUslo_KAO.Text = "Прочитать данные из файла InPutFileTask5V22.txt. Вывести в dataGridView.\r\nВывести" +
    " все числа, больше 5.  Построить диаграмму по этим значениям.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 531);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 22 |Коновалова А. О.";
            this.panel1.ResumeLayout(false);
            this.groupBoxUslo.ResumeLayout(false);
            this.groupBoxUslo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAO)).EndInit();
            this.groupBoxVvod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpenFile_KAO;
        private System.Windows.Forms.Button buttonInfo_KAO;
        private System.Windows.Forms.GroupBox groupBoxVvod;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KAO;
        private System.Windows.Forms.GroupBox groupBoxUslo;
        private System.Windows.Forms.Button buttonDone_KAO;
        private System.Windows.Forms.DataGridView dataGridViewResult_KAO;
        private System.Windows.Forms.Label labelUslo_KAO;
    }
}

