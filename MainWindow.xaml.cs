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

namespace WpfApp3class
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] colors = { "Navy", "Blue", "Aqua", "Teal", "Olive", "Green", "Lime", "Yellow", "Orange", "Red", "Maroon", "Fuchsia", "Purple", "Black", "Silver", "Gray", "White" };
        public MainWindow()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            foreach (string color in colors)
            {
                Button button = FindName(color + "Button") as Button;
                if (button != null)
                {
                    button.Content = color;
                    button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(color));
                    button.Margin = new Thickness(2.0);
                }
            }
        }
        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия на кнопку
            Button button = sender as Button;
            if (button != null)
            {
                MessageBox.Show($"Вы нажали на кнопку с цветом {button.Content}");
            }
        }
    }
}
    
   

