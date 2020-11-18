using FreshFruit.Controller;
using FreshFruit.Model;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEvenListener
    {
        Seller trias;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);
         trias = new Seller("trias", bucketController);
        ListBoxBucket.ItemsSource=keranjangBuah.findAll();
        }

           
        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            trias.addFruit(anggur);
            ListBoxBucket.Items.Refresh();

        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apple");
            trias.addFruit(apple);
            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("Banana");
            trias.addFruit(banana);
            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("Orange");
            trias.addFruit(orange);
            ListBoxBucket.Items.Refresh();
        }
    }
}
