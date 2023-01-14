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

namespace WpfEventsApp
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

        /*
        private void Generation1_Click(object sender, MouseButtonEventArgs e)
        {
            txtBlock.Text += ((FrameworkElement)sender).Name + " " + ((FrameworkElement)e.Source).Name + " " + ((FrameworkElement)e.OriginalSource).Name + "\n";

        }

        private void Generation2_Click(object sender, MouseButtonEventArgs e)
        {
            txtBlock.Text += ((FrameworkElement)sender).Name + " " + ((FrameworkElement)e.Source).Name + " " + ((FrameworkElement)e.OriginalSource).Name + "\n";
            e.Handled = true;
        }

        private void Generation3_Click(object sender, MouseButtonEventArgs e)
        {
            txtBlock.Text += ((FrameworkElement)sender).Name + " " + ((FrameworkElement)e.Source).Name + " " + ((FrameworkElement)e.OriginalSource).Name + "\n";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)e.Source;
            txtBlock.Text += rb.Content.ToString() + "\n";
        }

        private void txtBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            //int value;
            //if(!Int32.TryParse(e.Text, out value))
            //    e.Handled = true;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "Goodby world";
        }
        */

        private void txtBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(txtBox, txtBox.Text, DragDropEffects.Copy);
        }

        private void btn_Drop(object sender, DragEventArgs e)
        {
            btn.Content = e.Data.GetData(DataFormats.Text);
        }
    }
}
