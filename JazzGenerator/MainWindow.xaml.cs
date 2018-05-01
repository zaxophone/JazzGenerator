using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace JazzGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LeadBox_Checked(object sender, RoutedEventArgs e)
        {
            if (LeadBox.IsChecked == true)
            {
                Checked.LeadIsOn = true;
            }
            else
            {
                Checked.LeadIsOn = false;
            }

        }

        private void ChordsBox_Checked(object sender, RoutedEventArgs e)
        {
            if (ChordsBox.IsChecked == true)
            {
                Checked.ChordsIsOn = true;
            }
            else
            {
                Checked.ChordsIsOn = false;
            }
        }

        private void BassBox_Checked(object sender, RoutedEventArgs e)
        {
            if (BassBox.IsChecked == true)
            {
                Checked.BassIsOn = true;
            }
            else
            {
                Checked.BassIsOn = false;
            }
        }

        private void DrumsBox_Checked(object sender, RoutedEventArgs e)
        {
            if (DrumsBox.IsChecked == true)
            {
                Checked.DrumsIsOn = true;
            }
            else
            {
                Checked.DrumsIsOn = false;
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Generator.GenerateJazz();
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
            
        }
    }
}
