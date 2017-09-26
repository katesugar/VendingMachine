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

namespace Vending
{
    /// <summary>
    /// Логика взаимодействия для AddMoneyWindow.xaml
    /// </summary>
    public partial class AddMoneyWindow : Window
    {
        public event Action<int> MoneyAdded;
        int coin = 0;
        public AddMoneyWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            coin++;
            MoneyAdded?.Invoke(coin);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            coin = coin + 2;
            MoneyAdded?.Invoke(coin);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            coin = coin + 5;
            MoneyAdded?.Invoke(coin);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            coin = coin + 10;
            MoneyAdded?.Invoke(coin);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            coin = coin + 50;
            MoneyAdded?.Invoke(coin);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            coin = coin + 100;
            MoneyAdded?.Invoke(coin);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            coin = coin + 500;
            MoneyAdded?.Invoke(coin);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            coin = coin + 1000;
            MoneyAdded?.Invoke(coin);
        }
    }
}
