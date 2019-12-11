using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfAppFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomNum = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(TxtNum.Text);
            if (n < 1)
            {
                MessageBox.Show("Inserisci numeri SOLO postivi");
            }
            int[] random = new int[n];
            for (int i = 0; i < random.Length; i++)
            {
               random [i] = randomNum.Next(1,6);
            }
            LblRisultato.Content = "[";
            for(int i = 0; i < random.Length; i++)
            {
                LblRisultato.Content += $"{random[i]}";
                if (i < random.Length - 1)
                {
                    LblRisultato.Content += ",";
                }
            }
            LblRisultato.Content += "]";
            StreamWriter sw = new StreamWriter("random.txt");
            sw.WriteLine(random.Length);
            for (int i = 0; i<random.Length; i++)
            {
                sw.WriteLine(random[i]);
            }
            sw.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TxtNum.Clear();
        }
    }
}
