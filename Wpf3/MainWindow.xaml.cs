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
using System.IO;
using System.Collections.ObjectModel;

namespace Wpf3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<string> taskes;

        public MainWindow()
        {
            
            InitializeComponent();
            taskes = new ObservableCollection<string> { "fsafas" };
            list1.ItemsSource = taskes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string task = tx1.Text;
            taskes.Add(task);
            
        }

        private void task1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list1.TabIndex == list1.SelectedIndex)
               
                list1.SelectedIndex = list1.SelectedIndex;

            
            for (int x = list1.SelectedIndex - 1; x >= 0; x--)
            {
                list1.Items.Remove(x);
            }
        }
    }
}
