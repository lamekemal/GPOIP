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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GPOIP
{
    /// <summary>
    /// Logique d'interaction pour home.xaml
    /// </summary>
    public partial class home : Page
    {
        public home()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Hidden;
            AddForm.Visibility = Visibility.Visible;
        }

        private void progconBut_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Hidden;
            programationCours.Visibility = Visibility.Visible;
        }

        private void suiviButt_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Hidden;
            suiviProg.Visibility = Visibility.Visible;
        }

        private void modButtonx_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Hidden;
            editProg.Visibility = Visibility.Visible;
        }

        private void anulajFormbut_Click(object sender, RoutedEventArgs e)
        {
            AddForm.Visibility = Visibility.Hidden;
            HomeGrid.Visibility = Visibility.Visible;

        }

        private void progBack_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Visible;
            programationCours.Visibility = Visibility.Hidden;
        }

        private void suiviExe_Copy_Click(object sender, RoutedEventArgs e)
        {
                HomeGrid.Visibility = Visibility.Visible;
                suiviProg.Visibility = Visibility.Hidden;
        }

        private void mprogBack_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Visible;
            editProg.Visibility = Visibility.Hidden;
        }
    }
}
