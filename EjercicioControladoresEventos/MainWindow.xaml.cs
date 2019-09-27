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

namespace EjercicioControladoresEventos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BrushConverter bc = new BrushConverter();

        public MainWindow()
        {
            InitializeComponent();
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox2.IsReadOnly = true;
            focoTextBox.IsReadOnly = true;
            ratonTextBox.IsReadOnly = true;
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            RMBIndicator.Fill = (Brush)bc.ConvertFrom("Red");
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LMBIndicator.Fill = (Brush) bc.ConvertFrom("Red");
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LMBIndicator.Fill = (Brush)bc.ConvertFrom("white");
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            RMBIndicator.Fill = (Brush)bc.ConvertFrom("white");
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            ratonTextBox.Text = ((TextBox)sender).Name;
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            ratonTextBox.Text = "";
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F1)
                textBox2.Text = "Ayuda";
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.A:
                case Key.E:
                case Key.I:
                case Key.O:
                case Key.U:
                    e.Handled = true;
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            focoTextBox.Text = ((TextBox)sender).Name;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            focoTextBox.Text = "";
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox3.Text = new string(textBox3.Text.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
        }
    }
}
