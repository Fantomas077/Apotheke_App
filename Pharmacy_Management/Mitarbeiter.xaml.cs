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

namespace Pharmacy_Management
{
    /// <summary>
    /// Interaktionslogik für Mitarbeiter.xaml
    /// </summary>
    public partial class Mitarbeiter : Window
    {
        public Mitarbeiter()
        {
            InitializeComponent();
        }

        private void Abmeldenbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void medikamente_speichernbtn_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new medikamente_speichern();
        }
    }
}
