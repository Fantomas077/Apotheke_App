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
using System.Windows.Shapes;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;


namespace Pharmacy_Management
{
  
    /// <summary>
    /// Interaktionslogik für Administrator.xaml
    /// </summary>
    public partial class Administrator : Window
    {
       

       

        public Administrator()
        {
            
           
            InitializeComponent();
        }

        private void abmelden_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();

        }

        private void dashboard_btn_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Dashboard();

            
        }

        private void Main_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void User_add_btn_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new User_add();
        }

        private void useranzeigen_btn_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new UserView();









        }
    }
}
