using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using курсач.Core;

namespace курсач
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConnectionCore.CoreFrame = MainFrame;
            MainFrame.Navigate(new MainPage());

        }

        private void Window_MouseLeftButtonDown(object Sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2) 
            {
                Application.Current.Shutdown();
            }

        }

        
    }


  
}