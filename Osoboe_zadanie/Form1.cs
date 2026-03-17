using System;
using System.Windows.Forms;

namespace Osoboe_zadanie
{
    public partial class Form1 : Form
    {
        private Class1 qwe; // Добавил private

        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            label4.Text = "";
        }

        // Переименовываю методы с большой буквы (соблюдаем правила именования)
        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите строку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                qwe = new Class1(textBox1.Text);
                qwe.Creating(textBox1.Text, label2, label4, listBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void УсловиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void АвторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил: Человек ", "Об авторе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}