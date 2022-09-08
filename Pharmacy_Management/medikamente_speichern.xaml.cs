using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
    /// Interaktionslogik für medikamente_speichern.xaml
    /// </summary>
    public partial class medikamente_speichern : Page
    {
        string imglocation ;
        public medikamente_speichern()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {


            string name = nametxt.Text;
            string preis = preistxt.Text;
            string menge = mengetxt.Text;
           
           



            string connectionstring = " Data Source=FANTOMAS007\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);



            if (nametxt.Text == "" || preistxt.Text == "" || mengetxt.Text == "")
            {
                MessageBox.Show("geben sie alle informationnen ein");
            }


            else
            {
                try
                {
                   
                    con.Open();
                    string Query = "INSERT INTO Medikamente(name,preid,Menge,bild) VALUES('" + name + "', '" + preis + "', '" + menge + "','"+imagext+"')";

                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();

                    con.Close();


                    MessageBox.Show("good");



                }
                catch (Exception)
                {
                    MessageBox.Show("problemmm");
                }
            }




        }
        private void searchbtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Filter = "Images files|*.bmp;.jpg;*.png";
            opendialog.FilterIndex = 1;
            if (opendialog.ShowDialog() == true)
            {
               
               
               imagext.Source = new BitmapImage(new Uri(opendialog.FileName));

                
            }
        }

    }

      
    
}
