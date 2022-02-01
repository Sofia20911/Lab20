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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab20.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
            CMBServis.ItemsSource = Manager.db.Orders.ToList();
        }

        private void BTSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTcoce_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
