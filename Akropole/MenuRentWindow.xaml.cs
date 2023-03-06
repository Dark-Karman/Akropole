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

namespace Akropole
{
    /// <summary>
    /// Логика взаимодействия для MenuRentWindow.xaml
    /// </summary>
    public partial class MenuRentWindow : Window
    {
        public MenuRentWindow()
        {
            InitializeComponent();
        }

        private void overwatchBtn_Click(object sender, RoutedEventArgs e)
        {
            ListRentWindow listRentWindow = new ListRentWindow();
            listRentWindow.Show();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void otchetBtn_Click(object sender, RoutedEventArgs e)
        {
            OtchetRentWindow otchet = new OtchetRentWindow();
            otchet.Show();
        }
    }
}
