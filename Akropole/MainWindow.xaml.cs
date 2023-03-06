using Akropole.Model;
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

namespace Akropole
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            //манагер по аренде изменяет цены и видит толоько арендованое, а манагер по продажам добавляет и видит всё
            var user = Conection.entities.User.Where(i => i.login == loginTb.Text).FirstOrDefault();
            var pass = Conection.entities.User.Where(i => i.password == passPb.Password).FirstOrDefault();

            if (user != null && pass != null)
            {
                if(user.idRole == 1)
                {
                    MessageBox.Show("Manager");
                    MenuWindow menu = new MenuWindow();
                    menu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Rent manager");
                    MenuRentWindow menuRent = new MenuRentWindow();
                    menuRent.Show();
                    Close();
                }
            }

            else
            {
                MessageBox.Show("fuck");
            }
        }
    }
}
