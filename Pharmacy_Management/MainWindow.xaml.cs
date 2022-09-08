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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
             
            InitializeComponent();
        }

        private void Anmelden_btn_Click(object sender, RoutedEventArgs e)
        {
          

            string connectionString = "Data Source=FANTOMAS007\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                string login = "select userRole,Name from users where username='" + username_txt.Text + "'  and pass='" + pass_txt.Password + "'";

                SqlDataAdapter sqlog = new SqlDataAdapter(login, con);

                DataTable dt = new DataTable();

                sqlog.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    string ut = dt.Rows[0][0].ToString();

                    if (ut == "Administrator")
                    {
                        Administrator admin = new Administrator();
                       
                        
                        this.Close();
                        admin.Show();
                    }

                    else if (ut == "Mitarbeiter")
                    {
                        Mitarbeiter mitarbeiter = new Mitarbeiter();
                        this.Close();

                        mitarbeiter.Show();

                    }

                   
                   

                }
                else
                {
                    MessageBox.Show("Enteweder Username oder Password ist unkorrekt");

                    username_txt.Clear();
                    pass_txt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ibei der Registrierung" + ex);
            }

            finally
            {
                con.Close();
            }
          
        }

        private void reset_btn_Click(object sender, RoutedEventArgs e)
        {
            username_txt.Clear();
            pass_txt.Clear();
           
        }
    }

}