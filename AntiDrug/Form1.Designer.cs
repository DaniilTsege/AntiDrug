
namespace AntiDrug
{
    partial class Form1
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
            this.btOpenText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTextLoaded = new System.Windows.Forms.Label();
            this.btOpenBanWords = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBanWordsLoaded = new System.Windows.Forms.Label();
            this.lbBanWords = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btOpenText
            // 
            this.btOpenText.Location = new System.Drawing.Point(33, 46);
            this.btOpenText.Name = "btOpenText";
            this.btOpenText.Size = new System.Drawing.Size(215, 23);
            this.btOpenText.TabIndex = 0;
            this.btOpenText.Text = "Открыть";
            this.btOpenText.UseVisualStyleBackColor = true;
            this.btOpenText.Click += new System.EventHandler(this.btOpenText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Открыть файл с текстом";
            // 
            // lbTextLoaded
            // 
            this.lbTextLoaded.AutoSize = true;
            this.lbTextLoaded.Location = new System.Drawing.Point(254, 56);
            this.lbTextLoaded.Name = "lbTextLoaded";
            this.lbTextLoaded.Size = new System.Drawing.Size(72, 13);
            this.lbTextLoaded.TabIndex = 1;
            this.lbTextLoaded.Text = "Не загружен";
            // 
            // btOpenBanWords
            // 
            this.btOpenBanWords.Location = new System.Drawing.Point(33, 112);
            this.btOpenBanWords.Name = "btOpenBanWords";
            this.btOpenBanWords.Size = new System.Drawing.Size(215, 23);
            this.btOpenBanWords.TabIndex = 0;
            this.btOpenBanWords.Text = "Открыть";
            this.btOpenBanWords.UseVisualStyleBackColor = true;
            this.btOpenBanWords.Click += new System.EventHandler(this.btOpenBanWords_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Открыть файл с запрещенными словами";
            // 
            // lbBanWordsLoaded
            // 
            this.lbBanWordsLoaded.AutoSize = true;
            this.lbBanWordsLoaded.Location = new System.Drawing.Point(254, 117);
            this.lbBanWordsLoaded.Name = "lbBanWordsLoaded";
            this.lbBanWordsLoaded.Size = new System.Drawing.Size(72, 13);
            this.lbBanWordsLoaded.TabIndex = 1;
            this.lbBanWordsLoaded.Text = "Не загружен";
            // 
            // lbBanWords
            // 
            this.lbBanWords.AutoSize = true;
            this.lbBanWords.Location = new System.Drawing.Point(30, 213);
            this.lbBanWords.MaximumSize = new System.Drawing.Size(300, 150);
            this.lbBanWords.MinimumSize = new System.Drawing.Size(300, 150);
            this.lbBanWords.Name = "lbBanWords";
            this.lbBanWords.Size = new System.Drawing.Size(300, 150);
            this.lbBanWords.TabIndex = 2;
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(33, 160);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(215, 23);
            this.btCheck.TabIndex = 3;
            this.btCheck.Text = "Проверить";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Вероятность ";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 367);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbBanWords);
            this.Controls.Add(this.lbBanWordsLoaded);
            this.Controls.Add(this.lbTextLoaded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpenBanWords);
            this.Controls.Add(this.btOpenText);
            this.Name = "Form1";
            this.Text = "Антинаркотик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpenText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTextLoaded;
        private System.Windows.Forms.Button btOpenBanWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBanWordsLoaded;
        private System.Windows.Forms.Label lbBanWords;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

