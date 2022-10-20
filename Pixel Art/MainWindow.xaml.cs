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

namespace Pixel_Art
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Thickness thickness;
        private Brush brush;
        public MainWindow()
        {
            InitializeComponent();
            this.thickness = new Thickness();
            InicializaThickness();
        }

        private void AjustarTamaño(object sender, RoutedEventArgs e)
        {
            LimpiaLienzo();
            int value = int.Parse((string)(sender as Button).Tag);
            
            for (int i = 0; i<value; i++)
            {
                lienzo_Grid.RowDefinitions.Add(new RowDefinition());
                lienzo_Grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i<value; i++)
            {
                for (int j = 0; j<value; j++)
                {
                    Border border = new Border();

                    border.MouseLeftButtonDown += Border_MouseLeftButtonDown;
                    border.MouseEnter += Border_MouseEnter;
                    border.Background = Brushes.White;
                    border.BorderBrush = Brushes.Black;
                    border.BorderThickness = thickness;
                    
                    Grid.SetRow(border, i);
                    Grid.SetColumn(border, j);

                    lienzo_Grid.Children.Add(border);
                }
            }
            
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Border b = sender as Border;
                b.Background = brush;
            }
            
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Border b = sender as Border;
            b.Background = brush;
        }

        private void LimpiaLienzo()
        {
            lienzo_Grid.RowDefinitions.Clear();
            lienzo_Grid.ColumnDefinitions.Clear();
        }
        private void InicializaThickness()
        {
            thickness.Left = 0.1;
            thickness.Top = 0.1;
            thickness.Right = 0.1;
            thickness.Bottom = 0.1;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            string color = (string)(sender as RadioButton).Tag;
            Color col = (Color)ColorConverter.ConvertFromString(color);
            this.brush = new SolidColorBrush(col);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
