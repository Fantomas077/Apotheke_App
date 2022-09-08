using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Pharmacy_Management
{
    /// <summary>
    /// Interaktionslogik für Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
            string connectionString = "Data Source=FANTOMAS007\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            string login = "select count(*) from users where userRole = 'Administrator'";
            SqlCommand cmd = new SqlCommand(login, con);
            var count1 = cmd.ExecuteScalar();
            label1.Content = count1.ToString();



            string login1 = "select count(*) from users where userRole = 'Mitarbeiter'";
            SqlCommand cmd1 = new SqlCommand(login1, con);
            var count2 = cmd1.ExecuteScalar();
            label2.Content = count2.ToString();


            con.Close();




        }

        private void refreshbtn_Click(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
