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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ZMYA2Entities context;
        public MainWindow()
        {
            InitializeComponent();

            context = new ZMYA2Entities();
            ShowTable();

            
            
        }

        
        private void ShowTable()
        {
            DataGrid.ItemsSource = context.albums.ToList();
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var newRegistration = new groups();
            var newreg = new songs();
            context.groups.Add(newRegistration);
            context.songs.Add(newreg);

            var win = new Window1(context, newRegistration, newreg);
            win.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Form2_Click(object sender, RoutedEventArgs e)
        {
            //Window1 window1 = new Window1();
            //window1.Show();
        }
    }
}
