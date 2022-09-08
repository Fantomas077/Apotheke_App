using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für User_add.xaml
    /// </summary>
    public partial class User_add : Page
    {
      
       
        public User_add()
        {
            InitializeComponent();
        }

        private void btnRegistrieren_Click(object sender, RoutedEventArgs e)
        {
            string role = txtUserRole.Text;
            string name = txtName.Text;
            string geburstag = txtDob.Text;
            string mobile = txtHandy.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string pass = txtpassword.Password;

            string connectionstring = " Data Source=FANTOMAS007\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);



            if (txtUserRole.Text == "" || txtDob.Text == "" || txtName.Text==""|| txtHandy.Text==""|| txtUsername.Text==""|| txtpassword.Password=="" )
            {
                MessageBox.Show("geben sie alle informationnen ein");
            }

            
            else
            {
                try
                {
                    con.Open();
                    string Query = "INSERT INTO users(userRole,name,dob,mobile,email,username,pass) VALUES('" + role + "', '" + name + "', '" + geburstag + "', '" + mobile + "', '" + email + "', '" + username + "', '" + pass + "')";

                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();

                    con.Close();


                    MessageBox.Show("Registrierung erfolgreich");



                }
                catch (Exception)
                {
                    MessageBox.Show("Username existiert bereits");
                }
            }
           


        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtpassword.Clear();
            txtUsername.Clear();
            txtName.Clear();
            txtHandy.Clear();
            txtEmail.Clear();
           
        }
    }
}
