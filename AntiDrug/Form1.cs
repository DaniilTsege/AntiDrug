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

        private void btCheck_Click(object sender, EventArgs e)//проверка на запрещенные слова
        {

        }   
        string OpenTextFile()//выбор файла
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return "";
            // получаем выбранный файл
            return openFileDialog.FileName;
        }
    }
}
