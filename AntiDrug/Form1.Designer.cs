
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
            this.btOpenText.Location = new System.Drawing.Point(44, 57);
            this.btOpenText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOpenText.Name = "btOpenText";
            this.btOpenText.Size = new System.Drawing.Size(287, 28);
            this.btOpenText.TabIndex = 0;
            this.btOpenText.Text = "Открыть";
            this.btOpenText.UseVisualStyleBackColor = true;
            this.btOpenText.Click += new System.EventHandler(this.btOpenText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Открыть файл с текстом";
            // 
            // lbTextLoaded
            // 
            this.lbTextLoaded.AutoSize = true;
            this.lbTextLoaded.Location = new System.Drawing.Point(339, 69);
            this.lbTextLoaded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTextLoaded.Name = "lbTextLoaded";
            this.lbTextLoaded.Size = new System.Drawing.Size(90, 17);
            this.lbTextLoaded.TabIndex = 1;
            this.lbTextLoaded.Text = "Не загружен";
            // 
            // btOpenBanWords
            // 
            this.btOpenBanWords.Location = new System.Drawing.Point(44, 138);
            this.btOpenBanWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOpenBanWords.Name = "btOpenBanWords";
            this.btOpenBanWords.Size = new System.Drawing.Size(287, 28);
            this.btOpenBanWords.TabIndex = 0;
            this.btOpenBanWords.Text = "Открыть";
            this.btOpenBanWords.UseVisualStyleBackColor = true;
            this.btOpenBanWords.Click += new System.EventHandler(this.btOpenBanWords_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Открыть файл с запрещенными словами";
            // 
            // lbBanWordsLoaded
            // 
            this.lbBanWordsLoaded.AutoSize = true;
            this.lbBanWordsLoaded.Location = new System.Drawing.Point(339, 144);
            this.lbBanWordsLoaded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBanWordsLoaded.Name = "lbBanWordsLoaded";
            this.lbBanWordsLoaded.Size = new System.Drawing.Size(90, 17);
            this.lbBanWordsLoaded.TabIndex = 1;
            this.lbBanWordsLoaded.Text = "Не загружен";
            // 
            // lbBanWords
            // 
            this.lbBanWords.AutoSize = true;
            this.lbBanWords.Location = new System.Drawing.Point(40, 262);
            this.lbBanWords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBanWords.MaximumSize = new System.Drawing.Size(400, 185);
            this.lbBanWords.MinimumSize = new System.Drawing.Size(400, 185);
            this.lbBanWords.Name = "lbBanWords";
            this.lbBanWords.Size = new System.Drawing.Size(400, 185);
            this.lbBanWords.TabIndex = 2;
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(44, 197);
            this.btCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(287, 28);
            this.btCheck.TabIndex = 3;
            this.btCheck.Text = "Проверить";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Вероятность ";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 267);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbBanWords);
            this.Controls.Add(this.lbBanWordsLoaded);
            this.Controls.Add(this.lbTextLoaded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpenBanWords);
            this.Controls.Add(this.btOpenText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

