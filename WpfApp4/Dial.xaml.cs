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
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Dial.xaml
    /// </summary>
    public partial class Dial : Window
    {
        public Dial()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world");
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Hello, world";
            string caption = "World";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBox.Show(messageBoxText, caption, button);
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Hello, world";
            string caption = "World";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Hello to you too!");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Oh well, to bad!");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Never mind then");
                    break;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Hello, world";
            string caption = "Hello, world";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Question;
            MessageBox.Show(messageBoxText, caption, button, icon);
        }
    }
}
