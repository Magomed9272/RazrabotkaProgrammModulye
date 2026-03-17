using System;
using System.Windows.Forms;

namespace Osoboe_zadanie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.Text = "Условие задачи";
            this.Size = new System.Drawing.Size(500, 350);
            this.StartPosition = FormStartPosition.CenterScreen;

            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            textBox.ReadOnly = true;
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
            textBox.Text = "ЛАБОРАТОРНАЯ РАБОТА 6. Символьные данные ООП\n\n" +
                          "Цель работы: изучить структуру программ для построения графических\n" +
                          "объектов на основе использования метода объектно-ориентированного\n" +
                          "программирования\n\n" +
                          "Условие: ввести символьную строку из слов, которые разделены\n" +
                          "пробелами. Необходимо:\n" +
                          "1. Определить количество слов\n" +
                          "2. Найти самое короткое слово и его номер\n" +
                          "3. Подсчитать, сколько раз в каждом слове встречается буква «А»";

            this.Controls.Add(textBox);
        }
    }
}