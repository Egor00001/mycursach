using CW.Test.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task1Page());
        }
        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task2Page());
        }
        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task3Page());
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task4Page());
        }
        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task5Page());
        }
        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task6Page());
        }
        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task7Page());
        }
        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task8Page());
        }
        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task9Page());
        }
        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task10Page());
        }
        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?",
                                 "Системное сообщение",
                                  MessageBoxButton.YesNo,
                                  MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                CoreTest.TestFrame?.Navigate(new TaskPage());
            }
        }

        private int count = 0;

        public int FibRec(int n)
        {
            count++;
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return FibRec(n - 2) + FibRec(n - 1);
        }

        private void T4B(object sender, RoutedEventArgs e)
        {
            double[,] matrix = new double[6, 4];
            Random rand = new Random();
            double[] maxValues = new
            double[matrix.GetLength(0)];
            T4I.Text += "\n";
            T4I.Text += ("Дано:" + "\n");
            T4I.Text += "\n";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                    T4I.Text += (matrix[i, j] + "\t");
                }
                T4I.Text += "\n";
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double max = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                maxValues[i] = max;
            }
            T4II.Text += "\n";
            T4II.Text += ("Результат:" + "\n");
            T4II.Text += "\n";
            for (int i = 0; i < maxValues.Length; i++)
            {
               
                T4II.Text += (maxValues[i] + "\t");
            }
        }

    }
}



