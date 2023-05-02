using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using курсач.Core;

namespace курсач

{
    public partial class MainPage: Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTask_Click( object sender, RoutedEventArgs e )
        {
            ConnectionCore.CoreFrame?.Navigate(new TaskPage());
        }


        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }

}
