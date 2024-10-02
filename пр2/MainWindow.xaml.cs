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

namespace Пр2
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

        private void xd_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Этот метод можно оставить пустым или добавить логику, если нужно.
        }

        private void btn_NewPage(object sender, RoutedEventArgs e)
        {
            // Проверка на наличие букв и пустых значений
            if (!string.IsNullOrWhiteSpace(a.Text) &&
                !string.IsNullOrWhiteSpace(b.Text) &&
                !string.IsNullOrWhiteSpace(c.Text) &&
                double.TryParse(a.Text, out double aa) &&
                double.TryParse(b.Text, out double bb) &&
                double.TryParse(c.Text, out double cc))
            {
                double p = (aa + bb + cc) / 2;
                double S = Math.Sqrt(p * (p - aa) * (p - bb) * (p - cc));
                xd.Text = S.ToString();
            }
            else
            {
                xd.Text = "Введите корректные значения";
            }
        }
    }
}
