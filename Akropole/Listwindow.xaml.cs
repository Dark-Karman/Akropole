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
    /// Логика взаимодействия для Listwindow.xaml
    /// </summary>
    public partial class Listwindow : Window
    {
        public Listwindow()
        {
            InitializeComponent();
            flatLV.ItemsSource = Conection.entities.Flat.ToList();
            filterRoomCom.ItemsSource = Conection.entities.RoomsCount.ToList();
            countItems.Text = $"Total: {flatLV.Items.Count.ToString()}";
        }

        private void filterRoomCom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            flatLV.ItemsSource = Conection.entities.Flat.Where(i => i.idRoomsCount == ((RoomsCount)filterRoomCom.SelectedItem).id).ToList();
            countItems.Text = $"Total: {flatLV.Items.Count.ToString()}";
        }

        private void maxPriceTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var minP = Convert.ToDecimal(minPriceTb.Text);
            var maxP = Convert.ToDecimal(maxPriceTb.Text);
            flatLV.ItemsSource = Conection.entities.Flat.Where(i => i.marketPrice >= minP & i.marketPrice <= maxP).ToList();
            countItems.Text = $"Total: {flatLV.Items.Count.ToString()}";
        }

        private void dropBut_Click(object sender, RoutedEventArgs e)
        {
            filterRoomCom.SelectedItem = "";
            minPriceTb.Text = "0";
            maxPriceTb.Text = "0";
            flatLV.ItemsSource = Conection.entities.Flat.ToList();
            countItems.Text = $"Total: {flatLV.Items.Count.ToString()}";
        }
    }
}
