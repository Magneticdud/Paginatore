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

namespace Paginatore
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttongo_Click(object sender, RoutedEventArgs e)
        {
            textBoxoutput.Text = "";
            for (int i = 1; i <= slidermax.Value; i++)
            {
                textBoxoutput.Text += i.ToString() + ",";
                for (int j = 1; j < sliderpart.Value; j++)
                {
                    textBoxoutput.Text += (i + slidermax.Value * j).ToString() + ",";
                }
            }
        }
    }
}
