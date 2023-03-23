using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Wpf3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list1.Items.Add(new task { Name = tx1.Text, time = "12" });
            list1.Items.Refresh();

        }

        private void task1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            var firstPerson = list1.Items[list1.SelectedIndex];   // получаем первый объект
            list1.Items.Remove(firstPerson);




        }

        private void list1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
