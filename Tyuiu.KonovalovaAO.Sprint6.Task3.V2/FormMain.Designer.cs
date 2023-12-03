
namespace Tyuiu.KonovalovaAO.Sprint6.Task3.V2
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
            this.groupBoxUslovie_KAO = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrisa_KAO = new System.Windows.Forms.DataGridView();
            this.labeluslovie_KAO = new System.Windows.Forms.Label();
            this.groupBoxResult_KAO = new System.Windows.Forms.GroupBox();
            this.labelResult_KAO = new System.Windows.Forms.Label();
            this.buttonDone_KAO = new System.Windows.Forms.Button();
            this.buttonSpravka_KAO = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_KAO = new System.Windows.Forms.DataGridView();
            this.groupBoxUslovie_KAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrisa_KAO)).BeginInit();
            this.groupBoxResult_KAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KAO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_KAO
            // 
            this.groupBoxUslovie_KAO.Controls.Add(this.dataGridViewMatrix_KAO);
            this.groupBoxUslovie_KAO.Controls.Add(this.labeluslovie_KAO);
            this.groupBoxUslovie_KAO.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_KAO.Name = "groupBoxUslovie_KAO";
            this.groupBoxUslovie_KAO.Size = new System.Drawing.Size(751, 385);
            this.groupBoxUslovie_KAO.TabIndex = 0;
            this.groupBoxUslovie_KAO.TabStop = false;
            this.groupBoxUslovie_KAO.Text = "Условие";
            // 
            // dataGridViewMatrisa_KAO
            // 
            this.dataGridViewMatrisa_KAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrisa_KAO.ColumnHeadersVisible = false;
            this.dataGridViewMatrisa_KAO.Location = new System.Drawing.Point(22, 61);
            this.dataGridViewMatrisa_KAO.Name = "dataGridViewMatrisa_KAO";
            this.dataGridViewMatrisa_KAO.RowHeadersVisible = false;
            this.dataGridViewMatrisa_KAO.RowHeadersWidth = 51;
            this.dataGridViewMatrisa_KAO.RowTemplate.Height = 24;
            this.dataGridViewMatrisa_KAO.Size = new System.Drawing.Size(217, 195);
            this.dataGridViewMatrisa_KAO.TabIndex = 7;
            // 
            // labeluslovie_KAO
            // 
            this.labeluslovie_KAO.AutoSize = true;
            this.labeluslovie_KAO.Location = new System.Drawing.Point(17, 31);
            this.labeluslovie_KAO.Name = "labeluslovie_KAO";
            this.labeluslovie_KAO.Size = new System.Drawing.Size(339, 119);
            this.labeluslovie_KAO.TabIndex = 5;
            this.labeluslovie_KAO.Text = "Дан массив 5 на 5 элементов. \r\n-12  -4 -20   5  -5\r\n  2  15   1 -20   7\r\n  15 -15" +
    "   2  11   5\r\n- 19  -9  16   0   1\r\n   17  16   5  12  -8\r\nЗаменить четные значе" +
    "ния в первой строке на 0.\r\n";
            // 
            // groupBoxResult_KAO
            // 
            this.groupBoxResult_KAO.Controls.Add(this.dataGridViewMatrisa_KAO);
            this.groupBoxResult_KAO.Controls.Add(this.labelResult_KAO);
            this.groupBoxResult_KAO.Location = new System.Drawing.Point(786, 12);
            this.groupBoxResult_KAO.Name = "groupBoxResult_KAO";
            this.groupBoxResult_KAO.Size = new System.Drawing.Size(288, 314);
            this.groupBoxResult_KAO.TabIndex = 7;
            this.groupBoxResult_KAO.TabStop = false;
            this.groupBoxResult_KAO.Text = "Вывод данных";
            // 
            // labelResult_KAO
            // 
            this.labelResult_KAO.AutoSize = true;
            this.labelResult_KAO.Location = new System.Drawing.Point(19, 31);
            this.labelResult_KAO.Name = "labelResult_KAO";
            this.labelResult_KAO.Size = new System.Drawing.Size(76, 17);
            this.labelResult_KAO.TabIndex = 10;
            this.labelResult_KAO.Text = "Результат";
            // 
            // buttonDone_KAO
            // 
            this.buttonDone_KAO.Location = new System.Drawing.Point(886, 352);
            this.buttonDone_KAO.Name = "buttonDone_KAO";
            this.buttonDone_KAO.Size = new System.Drawing.Size(188, 45);
            this.buttonDone_KAO.TabIndex = 8;
            this.buttonDone_KAO.Text = "Выполнить";
            this.buttonDone_KAO.UseVisualStyleBackColor = true;
            this.buttonDone_KAO.Click += new System.EventHandler(this.buttonDone_KAO_Click);
            // 
            // buttonSpravka_KAO
            // 
            this.buttonSpravka_KAO.Location = new System.Drawing.Point(796, 352);
            this.buttonSpravka_KAO.Name = "buttonSpravka_KAO";
            this.buttonSpravka_KAO.Size = new System.Drawing.Size(58, 45);
            this.buttonSpravka_KAO.TabIndex = 9;
            this.buttonSpravka_KAO.Text = "?";
            this.buttonSpravka_KAO.UseVisualStyleBackColor = true;
            this.buttonSpravka_KAO.Click += new System.EventHandler(this.buttonSpravka_KAO_Click);
            // 
            // dataGridViewMatrix_KAO
            // 
            this.dataGridViewMatrix_KAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KAO.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_KAO.Location = new System.Drawing.Point(417, 31);
            this.dataGridViewMatrix_KAO.Name = "dataGridViewMatrix_KAO";
            this.dataGridViewMatrix_KAO.RowHeadersVisible = false;
            this.dataGridViewMatrix_KAO.RowHeadersWidth = 51;
            this.dataGridViewMatrix_KAO.RowTemplate.Height = 24;
            this.dataGridViewMatrix_KAO.Size = new System.Drawing.Size(313, 283);
            this.dataGridViewMatrix_KAO.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1087, 409);
            this.Controls.Add(this.buttonSpravka_KAO);
            this.Controls.Add(this.buttonDone_KAO);
            this.Controls.Add(this.groupBoxResult_KAO);
            this.Controls.Add(this.groupBoxUslovie_KAO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 |  Таск 3 | Вариант 2 | Коновалова А. О.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_KAO.ResumeLayout(false);
            this.groupBoxUslovie_KAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrisa_KAO)).EndInit();
            this.groupBoxResult_KAO.ResumeLayout(false);
            this.groupBoxResult_KAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_KAO;
        private System.Windows.Forms.Label labeluslovie_KAO;
        private System.Windows.Forms.GroupBox groupBoxResult_KAO;
        private System.Windows.Forms.DataGridView dataGridViewMatrisa_KAO;
        private System.Windows.Forms.Label labelResult_KAO;
        private System.Windows.Forms.Button buttonDone_KAO;
        private System.Windows.Forms.Button buttonSpravka_KAO;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KAO;
    }
}

