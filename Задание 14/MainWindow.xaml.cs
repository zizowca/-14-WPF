using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Задание_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Tomato",
                ProductPrice = 250,
                ProductPhoto = "Data/tomato.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Apple",
                ProductPrice = 150,
                ProductPhoto = "Data/apple.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Cheese",
                ProductPrice = 750,
                ProductPhoto = "Data/cheese.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Toaster",
                ProductPrice = 3000,
                ProductPhoto = "Data/toaster.jpg",
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Coffee machine",
                ProductPrice = 10000,
                ProductPhoto = "Data/coffeeMachine.jpg",
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Vacuum cleaner",
                ProductPrice = 20000,
                ProductPhoto = "Data/vacuumCleaner.jpg",
                ProductType = ProductTypes.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
