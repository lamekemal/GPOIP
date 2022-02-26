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

//librairie MySql ajouté precedement dans les references
using MySql.Data.MySqlClient;


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
            MySqlConnection con = new MySqlConnection();
            MySqlDataAdapter spa = new MySqlDataAdapter("Select count(*) From tblLogin where Username ='" + txtusername.Text +"'and password ='" + txtpassword.Text +"'",con );
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainWindow Main = new MainWindow();
                Main.Show();
            }
            else
            {
                MessageBox.Show("Mon utilisateur ou Mot de passe est incorrect. Veuillez ressayer");
            }


            MainWindow mainPage = new MainWindow();
            mainPage.Show();
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
