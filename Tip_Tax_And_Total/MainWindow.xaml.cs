//Author: Yao Zhou

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

namespace Tip_Tax_And_Total
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        double total = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void calc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = Input.Text;
                double price = double.Parse(input);
                double tips = price * 0.15;
                double tax = price * 0.07;
                total = price + tips + tax;
                tipsResult.Content = tips.ToString();
                taxResult.Content = tax.ToString();
                Total.Text = total.ToString();
            }
            catch
            {
                Input.Text = String.Empty;
                tipsResult.Content = String.Empty;
                taxResult.Content = String.Empty;
                Total.Text = "Please enter a valid number";
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Total.Text = String.Empty;
            tipsResult.Content = String.Empty;
            taxResult.Content = String.Empty;
            Input.Text = String.Empty;
        }
    }
}
