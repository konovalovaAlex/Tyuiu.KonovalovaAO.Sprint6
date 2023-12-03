
namespace Tyuiu.KonovalovaAO.Sprint6.Task0.V5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_KAO = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_KAO = new System.Windows.Forms.PictureBox();
            this.labeluslovie_KAO = new System.Windows.Forms.Label();
            this.groupBoxVvod_KAO = new System.Windows.Forms.GroupBox();
            this.labelPeremeX_KAO = new System.Windows.Forms.Label();
            this.textBoxInput_KAO = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KAO = new System.Windows.Forms.GroupBox();
            this.labelResult_KAO = new System.Windows.Forms.Label();
            this.textBoxResult_KAO = new System.Windows.Forms.TextBox();
            this.buttonVopros_KAO = new System.Windows.Forms.Button();
            this.buttonDonne_KAO = new System.Windows.Forms.Button();
            this.groupBoxTask_KAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KAO)).BeginInit();
            this.groupBoxVvod_KAO.SuspendLayout();
            this.groupBoxResult_KAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KAO
            // 
            this.groupBoxTask_KAO.Controls.Add(this.pictureBoxFormula_KAO);
            this.groupBoxTask_KAO.Controls.Add(this.labeluslovie_KAO);
            this.groupBoxTask_KAO.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KAO.Name = "groupBoxTask_KAO";
            this.groupBoxTask_KAO.Size = new System.Drawing.Size(767, 232);
            this.groupBoxTask_KAO.TabIndex = 0;
            this.groupBoxTask_KAO.TabStop = false;
            this.groupBoxTask_KAO.Text = "Условие";
            // 
            // pictureBoxFormula_KAO
            // 
            this.pictureBoxFormula_KAO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KAO.Image")));
            this.pictureBoxFormula_KAO.Location = new System.Drawing.Point(411, 21);
            this.pictureBoxFormula_KAO.Name = "pictureBoxFormula_KAO";
            this.pictureBoxFormula_KAO.Size = new System.Drawing.Size(335, 43);
            this.pictureBoxFormula_KAO.TabIndex = 1;
            this.pictureBoxFormula_KAO.TabStop = false;
            // 
            // labeluslovie_KAO
            // 
            this.labeluslovie_KAO.AutoSize = true;
            this.labeluslovie_KAO.Location = new System.Drawing.Point(17, 47);
            this.labeluslovie_KAO.Name = "labeluslovie_KAO";
            this.labeluslovie_KAO.Size = new System.Drawing.Size(241, 17);
            this.labeluslovie_KAO.TabIndex = 0;
            this.labeluslovie_KAO.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxVvod_KAO
            // 
            this.groupBoxVvod_KAO.Controls.Add(this.labelPeremeX_KAO);
            this.groupBoxVvod_KAO.Controls.Add(this.textBoxInput_KAO);
            this.groupBoxVvod_KAO.Location = new System.Drawing.Point(12, 259);
            this.groupBoxVvod_KAO.Name = "groupBoxVvod_KAO";
            this.groupBoxVvod_KAO.Size = new System.Drawing.Size(456, 120);
            this.groupBoxVvod_KAO.TabIndex = 1;
            this.groupBoxVvod_KAO.TabStop = false;
            this.groupBoxVvod_KAO.Text = "Ввод данных";
            // 
            // labelPeremeX_KAO
            // 
            this.labelPeremeX_KAO.AutoSize = true;
            this.labelPeremeX_KAO.Location = new System.Drawing.Point(14, 27);
            this.labelPeremeX_KAO.Name = "labelPeremeX_KAO";
            this.labelPeremeX_KAO.Size = new System.Drawing.Size(108, 17);
            this.labelPeremeX_KAO.TabIndex = 2;
            this.labelPeremeX_KAO.Text = "Переменная X:";
            // 
            // textBoxInput_KAO
            // 
            this.textBoxInput_KAO.Location = new System.Drawing.Point(17, 57);
            this.textBoxInput_KAO.Name = "textBoxInput_KAO";
            this.textBoxInput_KAO.Size = new System.Drawing.Size(138, 22);
            this.textBoxInput_KAO.TabIndex = 1;
            this.textBoxInput_KAO.TextChanged += new System.EventHandler(this.textBoxInput_KAO_TextChanged);
            this.textBoxInput_KAO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KAO_KeyPress);
            // 
            // groupBoxResult_KAO
            // 
            this.groupBoxResult_KAO.Controls.Add(this.labelResult_KAO);
            this.groupBoxResult_KAO.Controls.Add(this.textBoxResult_KAO);
            this.groupBoxResult_KAO.Location = new System.Drawing.Point(507, 259);
            this.groupBoxResult_KAO.Name = "groupBoxResult_KAO";
            this.groupBoxResult_KAO.Size = new System.Drawing.Size(272, 120);
            this.groupBoxResult_KAO.TabIndex = 1;
            this.groupBoxResult_KAO.TabStop = false;
            this.groupBoxResult_KAO.Text = "Вывод данных";
            // 
            // labelResult_KAO
            // 
            this.labelResult_KAO.AutoSize = true;
            this.labelResult_KAO.Location = new System.Drawing.Point(14, 27);
            this.labelResult_KAO.Name = "labelResult_KAO";
            this.labelResult_KAO.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KAO.TabIndex = 1;
            this.labelResult_KAO.Text = "Результат:";
            // 
            // textBoxResult_KAO
            // 
            this.textBoxResult_KAO.Location = new System.Drawing.Point(17, 57);
            this.textBoxResult_KAO.Name = "textBoxResult_KAO";
            this.textBoxResult_KAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult_KAO.TabIndex = 0;
            // 
            // buttonVopros_KAO
            // 
            this.buttonVopros_KAO.Location = new System.Drawing.Point(507, 385);
            this.buttonVopros_KAO.Name = "buttonVopros_KAO";
            this.buttonVopros_KAO.Size = new System.Drawing.Size(42, 42);
            this.buttonVopros_KAO.TabIndex = 2;
            this.buttonVopros_KAO.Text = "?";
            this.buttonVopros_KAO.UseVisualStyleBackColor = true;
            this.buttonVopros_KAO.Click += new System.EventHandler(this.buttonVopros_KAO_Click);
            // 
            // buttonDonne_KAO
            // 
            this.buttonDonne_KAO.Location = new System.Drawing.Point(596, 385);
            this.buttonDonne_KAO.Name = "buttonDonne_KAO";
            this.buttonDonne_KAO.Size = new System.Drawing.Size(183, 41);
            this.buttonDonne_KAO.TabIndex = 3;
            this.buttonDonne_KAO.Text = "Выполнить";
            this.buttonDonne_KAO.UseVisualStyleBackColor = true;
            this.buttonDonne_KAO.Click += new System.EventHandler(this.buttonDonne_KAO_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDonne_KAO);
            this.Controls.Add(this.buttonVopros_KAO);
            this.Controls.Add(this.groupBoxVvod_KAO);
            this.Controls.Add(this.groupBoxResult_KAO);
            this.Controls.Add(this.groupBoxTask_KAO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 5 | Коновалова А. О.";
            this.groupBoxTask_KAO.ResumeLayout(false);
            this.groupBoxTask_KAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KAO)).EndInit();
            this.groupBoxVvod_KAO.ResumeLayout(false);
            this.groupBoxVvod_KAO.PerformLayout();
            this.groupBoxResult_KAO.ResumeLayout(false);
            this.groupBoxResult_KAO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KAO;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KAO;
        private System.Windows.Forms.Label labeluslovie_KAO;
        private System.Windows.Forms.GroupBox groupBoxVvod_KAO;
        private System.Windows.Forms.Label labelPeremeX_KAO;
        private System.Windows.Forms.TextBox textBoxInput_KAO;
        private System.Windows.Forms.GroupBox groupBoxResult_KAO;
        private System.Windows.Forms.Label labelResult_KAO;
        private System.Windows.Forms.TextBox textBoxResult_KAO;
        private System.Windows.Forms.Button buttonVopros_KAO;
        private System.Windows.Forms.Button buttonDonne_KAO;
    }
}

