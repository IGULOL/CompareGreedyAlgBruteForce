using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Необходимо сравнить решения, полученные точным алгоритмом (перебором вариантов), 
 и одним и алгоритмов ниже. Результаты (время работы и оптимальность) сравнить.
 3. a) Задача укладки по дискетам (ящикам): Жадный алгоритм;
*/

namespace CompareGreedyAlgBruteForce
{
    public partial class MainForm : Form
    {
        int greedyAlg;
        int bruteForce;

        public MainForm()
        {
            InitializeComponent();
        }

        public void ShowRes(int N, long time, long time2, int res)
        {
            ListViewItem newItem;

            newItem = new ListViewItem(Convert.ToString(N));
            newItem.SubItems.Add(Convert.ToString(time));
            newItem.SubItems.Add(Convert.ToString(time2));
            newItem.SubItems.Add(Convert.ToString(res));
            listViewCompare.Items.Add(newItem);
        }

        private void textBoxSizes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //обрабатываем только числа, пробел и backspace
            if ((e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if ((textBoxSizes.Text == "") || (textBoxDiskette.Text == ""))
            {
                MessageBox.Show("Введите размеры файлов дискет.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int[] files = null;
                try
                {
                    files = textBoxSizes.Text.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).
                        Select(x => int.Parse(x)).ToArray();                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при вводе чисел.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                long time = 0;
                long time2 = 0;

                bruteForce = BruteForce.FindRes(files, int.Parse(textBoxDiskette.Text), out time);
                greedyAlg = GreedyAlg.FindRes(files, int.Parse(textBoxDiskette.Text), out time2);                

                ShowRes(files.Length, time, time2, greedyAlg);
                
            }
        }

    }
}
