
namespace Tyuiu.KonovalovaAO.Sprint6.Task7.V4
{
    partial class FormAbout
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
            this.buttonOK_KAO = new System.Windows.Forms.Button();
            this.labelInfo_KAO = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_KAO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAO)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_KAO
            // 
            this.buttonOK_KAO.Location = new System.Drawing.Point(532, 221);
            this.buttonOK_KAO.Name = "buttonOK_KAO";
            this.buttonOK_KAO.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_KAO.TabIndex = 0;
            this.buttonOK_KAO.Text = "OK";
            this.buttonOK_KAO.UseVisualStyleBackColor = true;
            this.buttonOK_KAO.Click += new System.EventHandler(this.buttonOK_KAO_Click);
            // 
            // labelInfo_KAO
            // 
            this.labelInfo_KAO.AutoSize = true;
            this.labelInfo_KAO.Location = new System.Drawing.Point(235, 26);
            this.labelInfo_KAO.Name = "labelInfo_KAO";
            this.labelInfo_KAO.Size = new System.Drawing.Size(363, 119);
            this.labelInfo_KAO.TabIndex = 1;
            this.labelInfo_KAO.Text = "Разработчик: Коновалова .А.О.\r\nгруппа СМАРТб-23-1\r\n\r\nПрограмма разработана в рамк" +
    "ах изучения языка C#\r\n\r\nТюменский Индустриальный Университет (с) 2023\r\nВысшая Шк" +
    "ола цифровых технологий (с) 2023 \r\n";
            // 
            // pictureBoxAvatar_KAO
            // 
            this.pictureBoxAvatar_KAO.Image = global::Tyuiu.KonovalovaAO.Sprint6.Task7.V4.Properties.Resources._2023_12_06_20_54_06;
            this.pictureBoxAvatar_KAO.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_KAO.Name = "pictureBoxAvatar_KAO";
            this.pictureBoxAvatar_KAO.Size = new System.Drawing.Size(204, 232);
            this.pictureBoxAvatar_KAO.TabIndex = 2;
            this.pictureBoxAvatar_KAO.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 256);
            this.Controls.Add(this.pictureBoxAvatar_KAO);
            this.Controls.Add(this.labelInfo_KAO);
            this.Controls.Add(this.buttonOK_KAO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_KAO;
        private System.Windows.Forms.Label labelInfo_KAO;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_KAO;
    }
}