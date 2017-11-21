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
using System.Threading;

namespace testwpfapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static bool tripleBeep = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string labelString = "this is my string";
            if (Convert.ToString(lblShowString.Content) == "Label" && chkBoxForButtonString.IsChecked == true)
            {
                lblShowString.Content = labelString;
            }
            else if (Convert.ToString(lblShowString.Content) == labelString)
            {
                lblShowString.Content = "Label";
            }  
            else
            {
                Console.Beep(200, 250);
            }
        }

        private void buttonPopWindow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("this is a pop-up window");
            MessageBox.Show("this is another pop-up window");
        }

        private void ButtonSoundBeep_Click(object sender, RoutedEventArgs e)
        {
            if (tripleBeep == false)
            {
                Console.Beep(500, 1000);
                tripleBeep = true;
                return;
            }
            for (int i=0; i<3; i++)
            {
                Console.Beep(500, 100);
                Thread.Sleep(50);
            }
        }

        private void buttonAddUp_Click(object sender, RoutedEventArgs e)
        {
            int addup = Convert.ToInt32(txtBoxAddUp.Content) + 1;
            txtBoxAddUp.Content = Convert.ToString(addup);
        }

        private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {
            int addup = Convert.ToInt32(txtBoxAddUp.Content) - 1;
            txtBoxAddUp.Content = Convert.ToString(addup);
        }

        private void buttonPower2_Click(object sender, RoutedEventArgs e)
        {
            int addup = Convert.ToInt32(txtBoxAddUp.Content) * 2;
            txtBoxAddUp.Content = Convert.ToString(addup);

        }
    }
}
