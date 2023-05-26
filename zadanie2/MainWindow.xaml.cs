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

namespace zadanie2
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
            if (K >= 20 && K <= 69)
            {
                int name = K / 10;
                int lo = K % 10;
                string K1 = "";

                switch (name)
                {
                    case 2:
                        {
                            K1 += "двадцать ";
                            break;
                        }
                    case 3:
                        {
                            K1 += "тридцать ";
                            break;
                        }
                    case 4:
                        {
                            K1 += "сорок ";
                            break;
                        }
                    case 5:
                        {
                            K1 += "пятьдесят ";
                            break;
                        }
                    case 6:
                        {
                            K1 += "шестьдесят ";
                            break;
                        }
                }
                switch (lo)
                {
                    case 1:
                        {
                            K1 += "один год";
                            break;
                        }
                    case 2:
                        {
                            K1 += "два года ";
                            break;
                        }
                    case 3:
                        {
                            K1 += "три года";
                            break;
                        }
                    case 4:
                        {
                            K1 += "четыре года";
                            break;
                        }
                    case 5:
                        {
                            K1 += "пять лет";
                            break;
                        }
                    case 6:
                        {
                            K1 += "шесть лет";
                            break;
                        }
                    case 7:
                        {
                            K1 += "семь лет";
                            break;
                        }
                    case 8:
                        {
                            K1 += "восемь лет";
                            break;
                        }
                    case 9:
                        {
                            K1 += "девять лет";
                            break;
                        }


                }
                otvet.Text = $"{K1}";
            }
            else { otvet.Text = ("ошибка"); }
        }
    }

}
