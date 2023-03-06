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
    /// Логика взаимодействия для AddFlatWindow.xaml
    /// </summary>
    public partial class AddFlatWindow : Window
    {
        public AddFlatWindow()
        {
            InitializeComponent();
            adresCom.ItemsSource = Conection.entities.Building.ToList();
            viewTypeCom.ItemsSource = Conection.entities.ViewType.ToList();
            roomsCountCom.ItemsSource = Conection.entities.RoomsCount.ToList();
            bathTypeCom.ItemsSource = Conection.entities.BathType.ToList();
            statusCom.ItemsSource = Conection.entities.Status.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Flat flat = new Flat();
            flat.idBuilding = ((Building)adresCom.SelectedItem).id;
            flat.myFlor = Convert.ToInt32(myFlorTb.Text);
            flat.idViewType = ((ViewType)viewTypeCom.SelectedItem).id;
            flat.idRoomsCount = ((RoomsCount)roomsCountCom.SelectedItem).id;
            flat.idBathType = ((BathType)bathTypeCom.SelectedItem).id;
            flat.bathCount = Convert.ToInt32(bathCountTb.Text);
            flat.condition = (Boolean)conditionCb.IsChecked;
            flat.cadastPrice = Convert.ToInt32(cadastPriceTb.Text);
            flat.marketPrice = Convert.ToInt32(marketPriceTb.Text);
            flat.rentPrice = Convert.ToInt32(rentPriceTb.Text);
            flat.idStatus = ((Status)statusCom.SelectedItem).id;
            Conection.entities.Flat.Add(flat);
            Conection.entities.SaveChanges();

            adresCom.Text = "";
            myFlorTb.Text = "";
            viewTypeCom.Text = "";
            roomsCountCom.Text = "";
            bathTypeCom.Text = "";
            bathCountTb.Text = "";
            conditionCb.IsChecked = false;
            cadastPriceTb.Text = "";
            marketPriceTb.Text = "";
            rentPriceTb.Text = "";
            statusCom.Text = "";
            MessageBox.Show("Запись добавлена");
            this.Close();
        }
    }
}
