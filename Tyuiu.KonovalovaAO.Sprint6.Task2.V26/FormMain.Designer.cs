
namespace Tyuiu.KonovalovaAO.Sprint6.Task2.V26
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewResult_KAO = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_KAO = new System.Windows.Forms.GroupBox();
            this.labelUslovi_KAO = new System.Windows.Forms.Label();
            this.labelUslovie_KAO = new System.Windows.Forms.Label();
            this.buttonDone_KAO = new System.Windows.Forms.Button();
            this.groupBoxResult_KAO = new System.Windows.Forms.GroupBox();
            this.chartResult_KAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_KAO = new System.Windows.Forms.Label();
            this.groupBoxVvod_KAO = new System.Windows.Forms.GroupBox();
            this.textBoxKonec_KAO = new System.Windows.Forms.TextBox();
            this.textBoxStart_KAO = new System.Windows.Forms.TextBox();
            this.labelkonec_KAO = new System.Windows.Forms.Label();
            this.labelStart_KAO = new System.Windows.Forms.Label();
            this.buttonSpravka_KAO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAO)).BeginInit();
            this.groupBoxUslovie_KAO.SuspendLayout();
            this.groupBoxResult_KAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAO)).BeginInit();
            this.groupBoxVvod_KAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewResult_KAO
            // 
            this.dataGridViewResult_KAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KAO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Fx});
            this.dataGridViewResult_KAO.Location = new System.Drawing.Point(20, 48);
            this.dataGridViewResult_KAO.Name = "dataGridViewResult_KAO";
            this.dataGridViewResult_KAO.RowHeadersVisible = false;
            this.dataGridViewResult_KAO.RowHeadersWidth = 51;
            this.dataGridViewResult_KAO.RowTemplate.Height = 24;
            this.dataGridViewResult_KAO.Size = new System.Drawing.Size(133, 290);
            this.dataGridViewResult_KAO.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 3;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Fx
            // 
            this.Fx.HeaderText = "Fx";
            this.Fx.MinimumWidth = 3;
            this.Fx.Name = "Fx";
            this.Fx.Width = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(440, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // groupBoxUslovie_KAO
            // 
            this.groupBoxUslovie_KAO.Controls.Add(this.labelUslovi_KAO);
            this.groupBoxUslovie_KAO.Controls.Add(this.labelUslovie_KAO);
            this.groupBoxUslovie_KAO.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_KAO.Name = "groupBoxUslovie_KAO";
            this.groupBoxUslovie_KAO.Size = new System.Drawing.Size(593, 257);
            this.groupBoxUslovie_KAO.TabIndex = 2;
            this.groupBoxUslovie_KAO.TabStop = false;
            this.groupBoxUslovie_KAO.Text = "Условие";
            // 
            // labelUslovi_KAO
            // 
            this.labelUslovi_KAO.AutoSize = true;
            this.labelUslovi_KAO.Location = new System.Drawing.Point(6, 48);
            this.labelUslovi_KAO.Name = "labelUslovi_KAO";
            this.labelUslovi_KAO.Size = new System.Drawing.Size(435, 17);
            this.labelUslovi_KAO.TabIndex = 9;
            this.labelUslovi_KAO.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // labelUslovie_KAO
            // 
            this.labelUslovie_KAO.AutoSize = true;
            this.labelUslovie_KAO.Location = new System.Drawing.Point(6, 27);
            this.labelUslovie_KAO.Name = "labelUslovie_KAO";
            this.labelUslovie_KAO.Size = new System.Drawing.Size(393, 17);
            this.labelUslovie_KAO.TabIndex = 4;
            this.labelUslovie_KAO.Text = "Протабулировать функцию sin(x) на заданном диапазоне.";
            // 
            // buttonDone_KAO
            // 
            this.buttonDone_KAO.BackColor = System.Drawing.Color.Transparent;
            this.buttonDone_KAO.Location = new System.Drawing.Point(440, 290);
            this.buttonDone_KAO.Name = "buttonDone_KAO";
            this.buttonDone_KAO.Size = new System.Drawing.Size(165, 76);
            this.buttonDone_KAO.TabIndex = 3;
            this.buttonDone_KAO.Text = "Выполнить";
            this.buttonDone_KAO.UseVisualStyleBackColor = false;
            this.buttonDone_KAO.Click += new System.EventHandler(this.buttonDone_KAO_Click);
            this.buttonDone_KAO.Enter += new System.EventHandler(this.buttonDone_KAO_Enter);
            this.buttonDone_KAO.Leave += new System.EventHandler(this.buttonDone_KAO_Leave);
            this.buttonDone_KAO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_KAO_MouseDown);
            this.buttonDone_KAO.MouseEnter += new System.EventHandler(this.buttonDone_KAO_Enter);
            // 
            // groupBoxResult_KAO
            // 
            this.groupBoxResult_KAO.Controls.Add(this.chartResult_KAO);
            this.groupBoxResult_KAO.Controls.Add(this.labelResult_KAO);
            this.groupBoxResult_KAO.Controls.Add(this.dataGridViewResult_KAO);
            this.groupBoxResult_KAO.Location = new System.Drawing.Point(611, 12);
            this.groupBoxResult_KAO.Name = "groupBoxResult_KAO";
            this.groupBoxResult_KAO.Size = new System.Drawing.Size(613, 354);
            this.groupBoxResult_KAO.TabIndex = 3;
            this.groupBoxResult_KAO.TabStop = false;
            this.groupBoxResult_KAO.Text = "Вывод данных";
            // 
            // chartResult_KAO
            // 
            chartArea5.Name = "ChartArea1";
            this.chartResult_KAO.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartResult_KAO.Legends.Add(legend5);
            this.chartResult_KAO.Location = new System.Drawing.Point(182, 48);
            this.chartResult_KAO.Name = "chartResult_KAO";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartResult_KAO.Series.Add(series5);
            this.chartResult_KAO.Size = new System.Drawing.Size(414, 290);
            this.chartResult_KAO.TabIndex = 9;
            this.chartResult_KAO.Text = "chart1";
            // 
            // labelResult_KAO
            // 
            this.labelResult_KAO.AutoSize = true;
            this.labelResult_KAO.Location = new System.Drawing.Point(17, 27);
            this.labelResult_KAO.Name = "labelResult_KAO";
            this.labelResult_KAO.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KAO.TabIndex = 8;
            this.labelResult_KAO.Text = "Результат:";
            // 
            // groupBoxVvod_KAO
            // 
            this.groupBoxVvod_KAO.Controls.Add(this.textBoxKonec_KAO);
            this.groupBoxVvod_KAO.Controls.Add(this.textBoxStart_KAO);
            this.groupBoxVvod_KAO.Controls.Add(this.labelkonec_KAO);
            this.groupBoxVvod_KAO.Controls.Add(this.labelStart_KAO);
            this.groupBoxVvod_KAO.Location = new System.Drawing.Point(12, 290);
            this.groupBoxVvod_KAO.Name = "groupBoxVvod_KAO";
            this.groupBoxVvod_KAO.Size = new System.Drawing.Size(286, 76);
            this.groupBoxVvod_KAO.TabIndex = 3;
            this.groupBoxVvod_KAO.TabStop = false;
            this.groupBoxVvod_KAO.Text = "Ввод данных";
            // 
            // textBoxKonec_KAO
            // 
            this.textBoxKonec_KAO.Location = new System.Drawing.Point(154, 38);
            this.textBoxKonec_KAO.Name = "textBoxKonec_KAO";
            this.textBoxKonec_KAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxKonec_KAO.TabIndex = 9;
            // 
            // textBoxStart_KAO
            // 
            this.textBoxStart_KAO.Location = new System.Drawing.Point(9, 38);
            this.textBoxStart_KAO.Name = "textBoxStart_KAO";
            this.textBoxStart_KAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_KAO.TabIndex = 8;
            // 
            // labelkonec_KAO
            // 
            this.labelkonec_KAO.AutoSize = true;
            this.labelkonec_KAO.Location = new System.Drawing.Point(151, 18);
            this.labelkonec_KAO.Name = "labelkonec_KAO";
            this.labelkonec_KAO.Size = new System.Drawing.Size(44, 17);
            this.labelkonec_KAO.TabIndex = 6;
            this.labelkonec_KAO.Text = "Стоп:";
            // 
            // labelStart_KAO
            // 
            this.labelStart_KAO.AutoSize = true;
            this.labelStart_KAO.Location = new System.Drawing.Point(6, 18);
            this.labelStart_KAO.Name = "labelStart_KAO";
            this.labelStart_KAO.Size = new System.Drawing.Size(51, 17);
            this.labelStart_KAO.TabIndex = 7;
            this.labelStart_KAO.Text = "Старт:";
            // 
            // buttonSpravka_KAO
            // 
            this.buttonSpravka_KAO.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSpravka_KAO.Location = new System.Drawing.Point(316, 290);
            this.buttonSpravka_KAO.Name = "buttonSpravka_KAO";
            this.buttonSpravka_KAO.Size = new System.Drawing.Size(118, 76);
            this.buttonSpravka_KAO.TabIndex = 5;
            this.buttonSpravka_KAO.Text = "Справка";
            this.buttonSpravka_KAO.UseVisualStyleBackColor = false;
            this.buttonSpravka_KAO.Click += new System.EventHandler(this.buttonSpravka_KAO_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 378);
            this.Controls.Add(this.buttonSpravka_KAO);
            this.Controls.Add(this.groupBoxVvod_KAO);
            this.Controls.Add(this.groupBoxResult_KAO);
            this.Controls.Add(this.buttonDone_KAO);
            this.Controls.Add(this.groupBoxUslovie_KAO);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 26 | Коновалова А. О.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAO)).EndInit();
            this.groupBoxUslovie_KAO.ResumeLayout(false);
            this.groupBoxUslovie_KAO.PerformLayout();
            this.groupBoxResult_KAO.ResumeLayout(false);
            this.groupBoxResult_KAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAO)).EndInit();
            this.groupBoxVvod_KAO.ResumeLayout(false);
            this.groupBoxVvod_KAO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResult_KAO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxUslovie_KAO;
        private System.Windows.Forms.Button buttonDone_KAO;
        private System.Windows.Forms.Label labelUslovie_KAO;
        private System.Windows.Forms.GroupBox groupBoxResult_KAO;
        private System.Windows.Forms.Label labelUslovi_KAO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KAO;
        private System.Windows.Forms.Label labelResult_KAO;
        private System.Windows.Forms.GroupBox groupBoxVvod_KAO;
        private System.Windows.Forms.TextBox textBoxKonec_KAO;
        private System.Windows.Forms.TextBox textBoxStart_KAO;
        private System.Windows.Forms.Label labelkonec_KAO;
        private System.Windows.Forms.Label labelStart_KAO;
        private System.Windows.Forms.Button buttonSpravka_KAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fx;
    }
}

