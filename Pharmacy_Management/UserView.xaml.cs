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
using System.Configuration;


namespace Pharmacy_Management
{
    /// <summary>
    /// Interaktionslogik für UserView.xaml
    /// </summary>
    public partial class UserView : Page
    {
        public UserView()
        {
            InitializeComponent();
            string connectionString = "Data Source=FANTOMAS007\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            string Query = "SELECT * FROM users";

            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            DateGridss.ItemsSource = table.DefaultView;


            con.Close();

        }

        private void löschenbtn_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=FANTOMAS007\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            if(usernametxt.Text=="")
            {
                MessageBox.Show("Username eingeben bitte!");

                
            }

            else
            {
                try
                {
                    con.Open();
                    string name = usernametxt.Text;

                    string Query = "DELETE FROM users WHERE username= '" + name + "'";

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Löschen erfolgreich");
                    con.Close();

                  
                }
                catch (Exception)
                {
                    MessageBox.Show("dieser Username wird nicht gefunden");
                }
            }

            
                
            
           

        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void suchenbtn_Click(object sender, RoutedEventArgs e)
        {
        


                  string connectionString = "Data Source=FANTOMAS007\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            string such = suchetxt.Text;

            string Query = "SELECT * FROM users WHERE name like '" + such + "%'";

            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            DateGridss.ItemsSource = table.DefaultView;


            con.Close();

        }
    }
}
