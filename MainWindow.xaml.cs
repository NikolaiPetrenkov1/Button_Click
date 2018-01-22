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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int safeHeight = 100;
        int safeWidth = 100;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunningButton_MouseEnter(object sender, MouseEventArgs e)
        {
            RunningButton.IsEnabled = false;
            Random random = new Random();
            int left = random.Next(0, safeHeight);
            int top = random.Next(0, safeWidth);
            Canvas.SetLeft(RunningButton, left);
            Canvas.SetTop(RunningButton, top);
        }

        private void RunningButton_MouseLeave(object sender, MouseEventArgs e)
        {
            RunningButton.Content = "Try to click!!!";
            RunningButton.IsEnabled = true;
        }

        private void RunningButton_Click(object sender, RoutedEventArgs e)
        {
            RunningButton.Content = "How you clicked me???";
        }
    }
}