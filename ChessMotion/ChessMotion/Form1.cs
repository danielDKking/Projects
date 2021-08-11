using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessMotion
{
    public partial class Form1 : Form
    {
        private List<char> ListAvailableLetters = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        private List<int> ListAvailableNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        public Form1()
        {
            InitializeComponent();

            cb_Number.SelectedIndex = 0;
            cb_Letter.SelectedIndex = 0;
        }

        private void btn_ShowAvailableCells_Click(object sender, EventArgs e)
        {
            char startLetter = cb_Letter.Items[cb_Letter.SelectedIndex].ToString().First();
            int startNumber = Convert.ToInt32(cb_Number.Items[cb_Number.SelectedIndex].ToString());

            List<(char letter, int number)> ListAvailableCells = GetAvailableCellsForQueen(startLetter, startNumber);

            tb_ListAvailableCells.Text = "";
            ListAvailableCells.ForEach(x => tb_ListAvailableCells.Text += "(" + x.letter + ";" + x.number + ")" + ";" + Environment.NewLine);
        }

        private List<(char letter, int number)> GetAvailableCellsForQueen(char startLetter, int startNumber) 
        {
            List<(char letter, int number)> ListAvailableCells = new List<(char letter, int number)>();

            // Получить все возможные вертикальные клетки
            foreach (int number in ListAvailableNumbers) 
            {
                // Исключение номера текущей позиции
                if (number == startNumber)
                    continue;

                ListAvailableCells.Add((startLetter, number));
            }
            // Получить все возможные горизнтальные клетки
            foreach (char letter in ListAvailableLetters)
            {
                // Исключение буквы текущей позиции
                if (letter == startLetter)
                    continue;

                ListAvailableCells.Add((letter, startNumber));
            }

            int y = ListAvailableLetters.IndexOf(startLetter) + 1; // координата символа доски
            int offsetY = y - startNumber; // Отклонение У от главной диагонали
            // Получить все возможные ходы по главной диагонали
            for (int i = 1; i <= 8; i++) 
            {
                // Исключение индексов за пределами границ массива и индекса текущей позиции
                if (i + offsetY - 1 < 0 || i + offsetY - 1 > 7 || i == startNumber)
                    continue;

                ListAvailableCells.Add((ListAvailableLetters[i + offsetY - 1], i));
            }

            offsetY = y - (8 - startNumber + 1); // Отклонение У от побочной диагонали
            int d = 1;
            // Получить все возможные ходы по побочной диагонали
            for (int i = 8; i >= 1; i--)
            {
                // Исключение индексов за пределами границ массива и индекса текущей позиции
                if (i + offsetY - 1 < 0 || i - i + offsetY - 1 > 7 || d == startNumber) 
                {
                    d++;
                    continue;
                }
                    
                ListAvailableCells.Add((ListAvailableLetters[i + offsetY - 1], d));
                d++;
            }

            return ListAvailableCells;
        }
    }
}
