
namespace Tyuiu.KonovalovaAO.Sprint6.Task4.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslo_KAO = new System.Windows.Forms.GroupBox();
            this.buttonDone_KAO = new System.Windows.Forms.Button();
            this.chartResult_KAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxVod_KAO = new System.Windows.Forms.GroupBox();
            this.textBoxStart_KAO = new System.Windows.Forms.TextBox();
            this.buttonSave_KAO = new System.Windows.Forms.Button();
            this.buttonNote_KAO = new System.Windows.Forms.Button();
            this.groupBoxVvob_KAO = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KAO = new System.Windows.Forms.TextBox();
            this.labelUslo_KAO = new System.Windows.Forms.Label();
            this.labelStart_KAO = new System.Windows.Forms.Label();
            this.panelAdept_KAO = new System.Windows.Forms.Panel();
            this.textBoxStop_KAO = new System.Windows.Forms.TextBox();
            this.labelKonec_KAO = new System.Windows.Forms.Label();
            this.groupBoxUslo_KAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAO)).BeginInit();
            this.groupBoxVod_KAO.SuspendLayout();
            this.groupBoxVvob_KAO.SuspendLayout();
            this.panelAdept_KAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslo_KAO
            // 
            this.groupBoxUslo_KAO.Controls.Add(this.labelUslo_KAO);
            this.groupBoxUslo_KAO.Location = new System.Drawing.Point(16, 15);
            this.groupBoxUslo_KAO.Name = "groupBoxUslo_KAO";
            this.groupBoxUslo_KAO.Size = new System.Drawing.Size(451, 76);
            this.groupBoxUslo_KAO.TabIndex = 1;
            this.groupBoxUslo_KAO.TabStop = false;
            this.groupBoxUslo_KAO.Text = "Условие";
            // 
            // buttonDone_KAO
            // 
            this.buttonDone_KAO.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonDone_KAO.Location = new System.Drawing.Point(725, 15);
            this.buttonDone_KAO.Name = "buttonDone_KAO";
            this.buttonDone_KAO.Size = new System.Drawing.Size(109, 76);
            this.buttonDone_KAO.TabIndex = 2;
            this.buttonDone_KAO.Text = "выполнить";
            this.buttonDone_KAO.UseVisualStyleBackColor = false;
            this.buttonDone_KAO.Click += new System.EventHandler(this.buttonDone_KAO_Click);
            // 
            // chartResult_KAO
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_KAO.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResult_KAO.Legends.Add(legend2);
            this.chartResult_KAO.Location = new System.Drawing.Point(214, 11);
            this.chartResult_KAO.Name = "chartResult_KAO";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_KAO.Series.Add(series2);
            this.chartResult_KAO.Size = new System.Drawing.Size(832, 439);
            this.chartResult_KAO.TabIndex = 3;
            this.chartResult_KAO.Text = "chart1";
            // 
            // groupBoxVod_KAO
            // 
            this.groupBoxVod_KAO.Controls.Add(this.labelKonec_KAO);
            this.groupBoxVod_KAO.Controls.Add(this.textBoxStop_KAO);
            this.groupBoxVod_KAO.Controls.Add(this.labelStart_KAO);
            this.groupBoxVod_KAO.Controls.Add(this.textBoxStart_KAO);
            this.groupBoxVod_KAO.Location = new System.Drawing.Point(473, 15);
            this.groupBoxVod_KAO.Name = "groupBoxVod_KAO";
            this.groupBoxVod_KAO.Size = new System.Drawing.Size(224, 76);
            this.groupBoxVod_KAO.TabIndex = 2;
            this.groupBoxVod_KAO.TabStop = false;
            this.groupBoxVod_KAO.Text = "Ввод";
            // 
            // textBoxStart_KAO
            // 
            this.textBoxStart_KAO.Location = new System.Drawing.Point(6, 39);
            this.textBoxStart_KAO.Name = "textBoxStart_KAO";
            this.textBoxStart_KAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_KAO.TabIndex = 0;
            // 
            // buttonSave_KAO
            // 
            this.buttonSave_KAO.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSave_KAO.Location = new System.Drawing.Point(840, 15);
            this.buttonSave_KAO.Name = "buttonSave_KAO";
            this.buttonSave_KAO.Size = new System.Drawing.Size(104, 76);
            this.buttonSave_KAO.TabIndex = 5;
            this.buttonSave_KAO.Text = "сохранить";
            this.buttonSave_KAO.UseVisualStyleBackColor = false;
            this.buttonSave_KAO.Click += new System.EventHandler(this.buttonSave_KAO_Click);
            // 
            // buttonNote_KAO
            // 
            this.buttonNote_KAO.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonNote_KAO.Location = new System.Drawing.Point(950, 15);
            this.buttonNote_KAO.Name = "buttonNote_KAO";
            this.buttonNote_KAO.Size = new System.Drawing.Size(112, 76);
            this.buttonNote_KAO.TabIndex = 6;
            this.buttonNote_KAO.Text = "справка";
            this.buttonNote_KAO.UseVisualStyleBackColor = false;
            this.buttonNote_KAO.Click += new System.EventHandler(this.buttonNote_KAO_Click);
            // 
            // groupBoxVvob_KAO
            // 
            this.groupBoxVvob_KAO.Controls.Add(this.textBoxResult_KAO);
            this.groupBoxVvob_KAO.Controls.Add(this.chartResult_KAO);
            this.groupBoxVvob_KAO.Location = new System.Drawing.Point(16, 97);
            this.groupBoxVvob_KAO.Name = "groupBoxVvob_KAO";
            this.groupBoxVvob_KAO.Size = new System.Drawing.Size(1046, 450);
            this.groupBoxVvob_KAO.TabIndex = 2;
            this.groupBoxVvob_KAO.TabStop = false;
            this.groupBoxVvob_KAO.Text = "Вывод";
            // 
            // textBoxResult_KAO
            // 
            this.textBoxResult_KAO.Location = new System.Drawing.Point(0, 21);
            this.textBoxResult_KAO.Multiline = true;
            this.textBoxResult_KAO.Name = "textBoxResult_KAO";
            this.textBoxResult_KAO.Size = new System.Drawing.Size(199, 423);
            this.textBoxResult_KAO.TabIndex = 0;
            // 
            // labelUslo_KAO
            // 
            this.labelUslo_KAO.AutoSize = true;
            this.labelUslo_KAO.Location = new System.Drawing.Point(6, 18);
            this.labelUslo_KAO.Name = "labelUslo_KAO";
            this.labelUslo_KAO.Size = new System.Drawing.Size(431, 51);
            this.labelUslo_KAO.TabIndex = 0;
            this.labelUslo_KAO.Text = "(произвести табулирование) f(x) на заданном диапазоне [-5; 5].\r\nРезультат вывести" +
    " в textBox, построить график функции и \r\nсохранить в файл OutPutFileTask4V25.txt" +
    " по нажатию кнопки. ";
            // 
            // labelStart_KAO
            // 
            this.labelStart_KAO.AutoSize = true;
            this.labelStart_KAO.Location = new System.Drawing.Point(6, 18);
            this.labelStart_KAO.Name = "labelStart_KAO";
            this.labelStart_KAO.Size = new System.Drawing.Size(81, 17);
            this.labelStart_KAO.TabIndex = 1;
            this.labelStart_KAO.Text = "старт шага";
            // 
            // panelAdept_KAO
            // 
            this.panelAdept_KAO.Controls.Add(this.groupBoxUslo_KAO);
            this.panelAdept_KAO.Controls.Add(this.groupBoxVvob_KAO);
            this.panelAdept_KAO.Controls.Add(this.groupBoxVod_KAO);
            this.panelAdept_KAO.Controls.Add(this.buttonNote_KAO);
            this.panelAdept_KAO.Controls.Add(this.buttonSave_KAO);
            this.panelAdept_KAO.Controls.Add(this.buttonDone_KAO);
            this.panelAdept_KAO.Location = new System.Drawing.Point(12, 3);
            this.panelAdept_KAO.Name = "panelAdept_KAO";
            this.panelAdept_KAO.Size = new System.Drawing.Size(1074, 554);
            this.panelAdept_KAO.TabIndex = 7;
            // 
            // textBoxStop_KAO
            // 
            this.textBoxStop_KAO.Location = new System.Drawing.Point(112, 39);
            this.textBoxStop_KAO.Name = "textBoxStop_KAO";
            this.textBoxStop_KAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_KAO.TabIndex = 3;
            // 
            // labelKonec_KAO
            // 
            this.labelKonec_KAO.AutoSize = true;
            this.labelKonec_KAO.Location = new System.Drawing.Point(109, 18);
            this.labelKonec_KAO.Name = "labelKonec_KAO";
            this.labelKonec_KAO.Size = new System.Drawing.Size(83, 17);
            this.labelKonec_KAO.TabIndex = 4;
            this.labelKonec_KAO.Text = "конец шага";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 565);
            this.Controls.Add(this.panelAdept_KAO);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_KAO";
            this.groupBoxUslo_KAO.ResumeLayout(false);
            this.groupBoxUslo_KAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAO)).EndInit();
            this.groupBoxVod_KAO.ResumeLayout(false);
            this.groupBoxVod_KAO.PerformLayout();
            this.groupBoxVvob_KAO.ResumeLayout(false);
            this.groupBoxVvob_KAO.PerformLayout();
            this.panelAdept_KAO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxUslo_KAO;
        private System.Windows.Forms.Button buttonDone_KAO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KAO;
        private System.Windows.Forms.GroupBox groupBoxVod_KAO;
        private System.Windows.Forms.TextBox textBoxStart_KAO;
        private System.Windows.Forms.Button buttonSave_KAO;
        private System.Windows.Forms.Button buttonNote_KAO;
        private System.Windows.Forms.GroupBox groupBoxVvob_KAO;
        private System.Windows.Forms.TextBox textBoxResult_KAO;
        private System.Windows.Forms.Label labelUslo_KAO;
        private System.Windows.Forms.Label labelStart_KAO;
        private System.Windows.Forms.Panel panelAdept_KAO;
        private System.Windows.Forms.TextBox textBoxStop_KAO;
        private System.Windows.Forms.Label labelKonec_KAO;
    }
}

