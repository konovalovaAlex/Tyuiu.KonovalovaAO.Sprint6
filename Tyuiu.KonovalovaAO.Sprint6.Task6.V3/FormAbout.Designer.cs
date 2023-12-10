
namespace Tyuiu.KonovalovaAO.Sprint6.Task6.V3
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonOK_KAO = new System.Windows.Forms.Button();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(240, 21);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(363, 119);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Разработчик: Коновалова .А.О.\r\nгруппа СМАРТб-23-1\r\n\r\nПрограмма разработана в рамк" +
    "ах изучения языка C#\r\n\r\nТюменский Индустриальный Университет (с) 2023\r\nВысшая Шк" +
    "ола цифровых технологий (с) 2023 ";
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // buttonOK_KAO
            // 
            this.buttonOK_KAO.Location = new System.Drawing.Point(536, 217);
            this.buttonOK_KAO.Name = "buttonOK_KAO";
            this.buttonOK_KAO.Size = new System.Drawing.Size(58, 32);
            this.buttonOK_KAO.TabIndex = 2;
            this.buttonOK_KAO.Text = "OK";
            this.buttonOK_KAO.UseVisualStyleBackColor = true;
            this.buttonOK_KAO.Click += new System.EventHandler(this.buttonOK_KAO_Click);
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.ErrorImage = global::Tyuiu.KonovalovaAO.Sprint6.Task6.V3.Properties.Resources._2023_12_06_20_31_58;
            this.pictureBoxAvatar.Image = global::Tyuiu.KonovalovaAO.Sprint6.Task6.V3.Properties.Resources._2023_12_06_20_30_19;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(12, 21);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(207, 228);
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 261);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK_KAO);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonOK_KAO;
    }
}