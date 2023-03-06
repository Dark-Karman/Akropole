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
using System.Windows.Shapes;

namespace Akropole
{
    /// <summary>
    /// Логика взаимодействия для OtchetRentWindow.xaml
    /// </summary>
    public partial class OtchetRentWindow : Window
    {
        public OtchetRentWindow()
        {
            InitializeComponent();
            rentLV.ItemsSource = Conection.entities.Rent.ToList();
            changFlatCom.ItemsSource = Conection.entities.Building.ToList();
            var money = Conection.entities.Rent.Sum(i => i.Flat.rentPrice);
            totalSum.Text = money.ToString();
        }

        private void filterBtn_Click(object sender, RoutedEventArgs e)
        {
            var selection = ((Building)changFlatCom.SelectedItem).id;
            var startPoint = (DateTime)starDp.SelectedDate;
            var endPoint = (DateTime)endDp.SelectedDate;
            var money = Conection.entities.Rent.Where(i => i.dateStart >= startPoint && i.dateStart <= endPoint).Sum(i => i.Flat.rentPrice);
            rentLV.ItemsSource = Conection.entities.Rent.Where(i => i.dateStart >= startPoint && i.dateStart <= endPoint & i.Flat.Building.id == selection).ToList();
            totalSum.Text = money.ToString();
            
        }

        private void changFlatCom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = ((Building)changFlatCom.SelectedItem).id;
            rentLV.ItemsSource = Conection.entities.Rent.Where(i=> i.Flat.Building.id == selection).ToList();
        }
    }
}
