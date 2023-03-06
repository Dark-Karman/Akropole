using Akropole.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для ListRentWindow.xaml
    /// </summary>
    public partial class ListRentWindow : Window
    {
        
        public ListRentWindow()
        {
            InitializeComponent();
            flatLV.ItemsSource = Conection.entities.Flat.Where(i => i.idStatus == 3).ToList();
            countItems.Text = $"Total: {flatLV.Items.Count.ToString()}";
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            var select_id = ((Flat)flatLV.SelectedItem).id;
            string newKad = kadPriceTb.Text;
            string newMarket = marketPriceTb.Text;
            string newRent = rentPriceTb.Text;
            //Flat flat = UserHelper.flat;
            var flat = Conection.entities.Flat.Where(i => i.id == select_id).FirstOrDefault();
            flat.cadastPrice = Convert.ToDecimal(newKad);
            flat.marketPrice = Convert.ToDecimal(newMarket);
            flat.rentPrice = Convert.ToDecimal(newRent);
            Conection.entities.Flat.AddOrUpdate(flat);
            Conection.entities.SaveChanges();
            MessageBox.Show("Данные обновлены");

            flatLV.ItemsSource = Conection.entities.Flat.Where(i => i.idStatus == 3).ToList();
            countItems.Text = $"Total: {flatLV.Items.Count.ToString()}";
        }

        private void flatLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            kadPriceTb.Text = ((Flat)flatLV.SelectedItem).cadastPrice.ToString();
            marketPriceTb.Text= ((Flat)flatLV.SelectedItem).marketPrice.ToString();
            rentPriceTb.Text = ((Flat)flatLV.SelectedItem).rentPrice.ToString();

        }
    }
}
