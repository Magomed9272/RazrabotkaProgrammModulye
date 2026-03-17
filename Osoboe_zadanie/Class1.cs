using System;
using System.Windows.Forms;

namespace Osoboe_zadanie
{
    public class Class1
    {
        // Убрал неиспользуемую переменную 'text'
        private int wordCount;
        private int shortestWordIndex;
        private int letterCount;

        public Class1(string inputText) // параметр оставил, но не сохраняю
        {
            // Ничего не сохраняем, так как inputText не используется в классе
        }

        public void Creating(string inputText, Label l2, Label l4, ListBox lb)
        {
            string[] words = inputText.Split(new char[] { ' ', ',', '.', '?', '!', ';', ':' },
                StringSplitOptions.RemoveEmptyEntries);

            wordCount = words.Length;
            l2.Text = "Количество слов: " + wordCount;
            lb.Items.Clear();

            if (wordCount == 0)
            {
                l4.Text = "Нет слов для анализа";
                lb.Items.Add("Введите текст для анализа");
                return;
            }

            int minLength = words[0].Length;
            shortestWordIndex = 0;

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length < minLength)
                {
                    minLength = words[i].Length;
                    shortestWordIndex = i;
                }
            }

            l4.Text = $"Самое короткое слово: '{words[shortestWordIndex]}' (слово №{shortestWordIndex + 1})";

            lb.Items.Add("=== Результаты подсчета буквы 'А' ===");

            for (int i = 0; i < words.Length; i++)
            {
                letterCount = 0;

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (words[i][j] == 'А' || words[i][j] == 'а')
                    {
                        letterCount++;
                    }
                }

                lb.Items.Add($"Слово {i + 1}: '{words[i]}' — буква 'А' встречается {letterCount} раз");
            }
        }
    }
}