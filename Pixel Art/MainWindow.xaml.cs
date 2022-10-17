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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AjustarTamaño(object sender, RoutedEventArgs e)
        {
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
                }
            }
        }
    }
}
