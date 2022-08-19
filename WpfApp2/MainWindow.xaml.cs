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

namespace WpfApp2
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

        private void exp_Expanded(object sender, RoutedEventArgs e)
        {
            
            if (exp.IsExpanded)
            {
                exp.BorderBrush = Brushes.DeepSkyBlue;
            }
        }



        private void exp_MouseLeave(object sender, MouseEventArgs e)
        {
            exp.BorderBrush = Brushes.WhiteSmoke;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}
        //public int Count { get; set; } = 0;
        //private void btn_Click(object sender, RoutedEventArgs e)
        //{
        //    Count++;
        //    btn.Content = Count.ToString();
        //}

        //private void repeat_button_Click(object sender, RoutedEventArgs e)
        //{
        //    Count++;
        //    repeat_button.Content = Count.ToString();
        //}

        //private void toogle_button_Click(object sender, RoutedEventArgs e)
        //{
        //    Count++;
        //    toogle_button.Content = Count.ToString();
        //}
    }
}
