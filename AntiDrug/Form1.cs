using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiDrug
{
    public partial class Form1 : Form
    {
        string[] words;
        string[] banWords;
        public Form1()
        {
            InitializeComponent();
        }
        private void btOpenText_Click(object sender, EventArgs e)//загрузка текста
        {
            string path = OpenTextFile();
            if (path != "")
            {
                words = File.ReadAllText(path).Split(' ');//разделение файла на слова
                lbTextLoaded.Text = "Загружен";
            }
        }

        private void btOpenBanWords_Click(object sender, EventArgs e)//загрузка запрещенных слов
        {
            string path = OpenTextFile();
            if (path != "")
            {
                banWords = File.ReadAllText(path).Split('|');//разделение файла на слова
                lbBanWordsLoaded.Text = "Загружен";

            }
        }

        private void btCheck_Click(object sender, EventArgs e)//проверка на запрещенные слова и определение вероятности
        {

            label7.Text = FindProbability();
        }
        string OpenTextFile()//выбор файла
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return "";
            // получаем выбранный файл
            return openFileDialog.FileName;
        }
        string FindProbability()
        {
            double all_words = words.Length;
            double banned_words = banWords.Length;
            for (int i = 0; i < banned_words; i++)
                for (int j = i + 1; j < banned_words; j++)
                {
                    if (banWords[i] == banWords[j]) banned_words -= 1;
                }
            return "Вероятность: " + (banned_words / all_words * 100) + "%";

        }
    }
}
