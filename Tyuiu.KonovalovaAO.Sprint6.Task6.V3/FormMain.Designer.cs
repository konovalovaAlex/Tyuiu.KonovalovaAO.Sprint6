
namespace Tyuiu.KonovalovaAO.Sprint6.Task6.V3
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask_KAO = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxUslo_KAO = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutData_KAO = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_KAO = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_KAO = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_KAO = new System.Windows.Forms.TextBox();
            this.labelUslo = new System.Windows.Forms.Label();
            this.buttonDone_KAO = new System.Windows.Forms.Button();
            this.buttonInfo_KAO = new System.Windows.Forms.Button();
            this.buttonOpenFile_KAO = new System.Windows.Forms.Button();
            this.groupBoxUslo_KAO.SuspendLayout();
            this.groupBoxInPutData_KAO.SuspendLayout();
            this.groupBoxOutPutData_KAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask_KAO
            // 
            this.openFileDialogTask_KAO.FileName = "openFileDialog1";
            // 
            // groupBoxUslo_KAO
            // 
            this.groupBoxUslo_KAO.Controls.Add(this.labelUslo);
            this.groupBoxUslo_KAO.Location = new System.Drawing.Point(12, 96);
            this.groupBoxUslo_KAO.Name = "groupBoxUslo_KAO";
            this.groupBoxUslo_KAO.Size = new System.Drawing.Size(910, 85);
            this.groupBoxUslo_KAO.TabIndex = 0;
            this.groupBoxUslo_KAO.TabStop = false;
            this.groupBoxUslo_KAO.Text = "Условие";
            // 
            // groupBoxInPutData_KAO
            // 
            this.groupBoxInPutData_KAO.Controls.Add(this.textBoxInPutData_KAO);
            this.groupBoxInPutData_KAO.Location = new System.Drawing.Point(15, 184);
            this.groupBoxInPutData_KAO.Name = "groupBoxInPutData_KAO";
            this.groupBoxInPutData_KAO.Size = new System.Drawing.Size(433, 290);
            this.groupBoxInPutData_KAO.TabIndex = 3;
            this.groupBoxInPutData_KAO.TabStop = false;
            this.groupBoxInPutData_KAO.Text = "Ввод";
            // 
            // textBoxInPutData_KAO
            // 
            this.textBoxInPutData_KAO.Location = new System.Drawing.Point(6, 21);
            this.textBoxInPutData_KAO.Multiline = true;
            this.textBoxInPutData_KAO.Name = "textBoxInPutData_KAO";
            this.textBoxInPutData_KAO.Size = new System.Drawing.Size(421, 263);
            this.textBoxInPutData_KAO.TabIndex = 1;
            // 
            // groupBoxOutPutData_KAO
            // 
            this.groupBoxOutPutData_KAO.Controls.Add(this.textBoxOutPutData_KAO);
            this.groupBoxOutPutData_KAO.Location = new System.Drawing.Point(489, 184);
            this.groupBoxOutPutData_KAO.Name = "groupBoxOutPutData_KAO";
            this.groupBoxOutPutData_KAO.Size = new System.Drawing.Size(433, 290);
            this.groupBoxOutPutData_KAO.TabIndex = 4;
            this.groupBoxOutPutData_KAO.TabStop = false;
            this.groupBoxOutPutData_KAO.Text = "Вывод";
            // 
            // textBoxOutPutData_KAO
            // 
            this.textBoxOutPutData_KAO.Location = new System.Drawing.Point(6, 21);
            this.textBoxOutPutData_KAO.Multiline = true;
            this.textBoxOutPutData_KAO.Name = "textBoxOutPutData_KAO";
            this.textBoxOutPutData_KAO.Size = new System.Drawing.Size(421, 263);
            this.textBoxOutPutData_KAO.TabIndex = 2;
            // 
            // labelUslo
            // 
            this.labelUslo.AutoSize = true;
            this.labelUslo.Location = new System.Drawing.Point(33, 18);
            this.labelUslo.Name = "labelUslo";
            this.labelUslo.Size = new System.Drawing.Size(554, 51);
            this.labelUslo.TabIndex = 7;
            this.labelUslo.Text = "Дан файл InPutFileTask6V3.txt который может находится в любом месте на диске. \r\nЗ" +
    "агрузить файл в textBoxIn через openFileDialog. \r\nВывести слова в которых встреч" +
    "ается r в результирующею строку";
            // 
            // buttonDone_KAO
            // 
            this.buttonDone_KAO.Image = global::Tyuiu.KonovalovaAO.Sprint6.Task6.V3.Properties.Resources.page_go;
            this.buttonDone_KAO.Location = new System.Drawing.Point(120, 12);
            this.buttonDone_KAO.Name = "buttonDone_KAO";
            this.buttonDone_KAO.Size = new System.Drawing.Size(93, 78);
            this.buttonDone_KAO.TabIndex = 6;
            this.toolTip.SetToolTip(this.buttonDone_KAO, "производит поиск в файле вхождение символов \"*\"\r\nи конкатипует строки в которых н" +
        "аходятся \r\nэти символы");
            this.buttonDone_KAO.UseVisualStyleBackColor = true;
            this.buttonDone_KAO.Click += new System.EventHandler(this.buttonDone_KAO_Click);
            // 
            // buttonInfo_KAO
            // 
            this.buttonInfo_KAO.Image = global::Tyuiu.KonovalovaAO.Sprint6.Task6.V3.Properties.Resources.exclamation;
            this.buttonInfo_KAO.Location = new System.Drawing.Point(823, 12);
            this.buttonInfo_KAO.Name = "buttonInfo_KAO";
            this.buttonInfo_KAO.Size = new System.Drawing.Size(93, 78);
            this.buttonInfo_KAO.TabIndex = 5;
            this.toolTip.SetToolTip(this.buttonInfo_KAO, "Свединия о программе");
            this.buttonInfo_KAO.UseVisualStyleBackColor = true;
            this.buttonInfo_KAO.Click += new System.EventHandler(this.buttonInfo_KAO_Click);
            // 
            // buttonOpenFile_KAO
            // 
            this.buttonOpenFile_KAO.Image = global::Tyuiu.KonovalovaAO.Sprint6.Task6.V3.Properties.Resources.folder_page_white;
            this.buttonOpenFile_KAO.Location = new System.Drawing.Point(21, 12);
            this.buttonOpenFile_KAO.Name = "buttonOpenFile_KAO";
            this.buttonOpenFile_KAO.Size = new System.Drawing.Size(93, 78);
            this.buttonOpenFile_KAO.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonOpenFile_KAO, "Открыть нужный файл для обработки");
            this.buttonOpenFile_KAO.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KAO.Click += new System.EventHandler(this.buttonOpenFile_KAO_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.buttonDone_KAO);
            this.Controls.Add(this.buttonInfo_KAO);
            this.Controls.Add(this.groupBoxOutPutData_KAO);
            this.Controls.Add(this.buttonOpenFile_KAO);
            this.Controls.Add(this.groupBoxInPutData_KAO);
            this.Controls.Add(this.groupBoxUslo_KAO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxUslo_KAO.ResumeLayout(false);
            this.groupBoxUslo_KAO.PerformLayout();
            this.groupBoxInPutData_KAO.ResumeLayout(false);
            this.groupBoxInPutData_KAO.PerformLayout();
            this.groupBoxOutPutData_KAO.ResumeLayout(false);
            this.groupBoxOutPutData_KAO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KAO;
        private System.Windows.Forms.GroupBox groupBoxUslo_KAO;
        private System.Windows.Forms.Button buttonOpenFile_KAO;
        private System.Windows.Forms.GroupBox groupBoxInPutData_KAO;
        private System.Windows.Forms.TextBox textBoxInPutData_KAO;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_KAO;
        private System.Windows.Forms.TextBox textBoxOutPutData_KAO;
        private System.Windows.Forms.Button buttonInfo_KAO;
        private System.Windows.Forms.Button buttonDone_KAO;
        private System.Windows.Forms.Label labelUslo;
    }
}

