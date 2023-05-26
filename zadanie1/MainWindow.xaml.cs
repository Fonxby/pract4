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

namespace zadanie1
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
            int K = int.Parse(vvod.Text);
            if (K == 1)
            {
                otvet.Text = ($"плохо");
            }
            else if (K == 2)
            {
                otvet.Text = ($"неудовлетворительно");
            }
            else if (K == 3)
            { 
                otvet.Text = ($"удовлетворительно"); 
            }
            else if (K == 4)
            {
                otvet.Text = ($"хорошо");
            }
            else if (K == 5)
            { 
                otvet.Text = ($"отлично");
            }
            else 
            if ( K > 5)
            {
                otvet.Text = ($"ошибка");
            }

        }
    }
}
