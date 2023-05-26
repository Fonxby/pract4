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

namespace wer
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

        private void knopka_Click(object sender, RoutedEventArgs e)
        {
            int K = int.Parse(vozrast.Text);
            string name;
            switch (K)
            {
                case 2:
                    {
                        name = "двадцать ";
                        break;
                    }
                case 3:
                    {
                        name = "тридцать ";
                        break;
                    }
                case 4:
                    {
                        name = "сорок ";
                        break;
                    }
                case 5:
                    {
                        name = "пятьдесят ";
                        break;
                    }
                case 6:
                    {
                        name = "шестьдесят ";
                        break;
                    }
            }
            otvet.Text = $"{}";
        }
    }
}
