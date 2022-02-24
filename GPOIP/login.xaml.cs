using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GPOIP
{
    /// <summary>
    /// Logique d'interaction pour login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void closeButon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainPage = new MainWindow();
            mainPage.Show();
            Close();
        }
    }
}
