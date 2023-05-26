using CW.Test.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class Task10Page : Page
    {
        public Task10Page()
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
        private void T10B(object sender, RoutedEventArgs e)
        {
            double[,] matrix = new double[7, 7];


            Random rnd = new Random();
            T10I.Text += "\n";
            T10I.Text += ("Дано:" + "\n");
            T10I.Text += "\n";
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matrix[i, j] = rnd.Next(-100, 100);
                    T10I.Text += (matrix[i, j] + "\t");
                }
                T10I.Text += "\n";
            }

            for (int i = 0; i < 7; i++)
            {
                double tmp = matrix[i, i];
                matrix[i, i] = matrix[i, 6 - i];
                matrix[i, 6 - i] = tmp;
            }

            T10II.Text += ("Результат:" + "\n");
            T10II.Text += "\n";
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    T10II.Text += (matrix[i, j] + "\t");
                }
                T10II.Text += "\n";
            }
        }
    }
}
