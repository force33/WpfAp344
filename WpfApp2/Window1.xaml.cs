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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ZMYA2Entities context;
        
        public Window1(ZMYA2Entities context, groups groups, songs songs)
        {
            InitializeComponent();

            this.context = context;
            //CmbGroup.Text = context.groups.ToString();
            //CmbSongs.Text = context.songs.ToString();
            this.DataContext = groups;
            //this.DataContext = songs;
        }

        private void CmbArtists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            string dksks = CmbGroup.Text;
            var reg = (groups)this.DataContext;
            reg.group_name = dksks;
            context.SaveChanges();
            //string mgklsj = CmbSongs.Text;
            //var reg1 = (songs)DataContext;
            //reg1.song_name = mgklsj;
            //context.SaveChanges();
        }

        private void CmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void BtnSave2_Click(object sender, RoutedEventArgs e)
        //{
        //    string dksks = CmbGroup.Text;
        //    var reg = (groups)this.DataContext;
        //    reg.group_name = dksks;
        //    context.SaveChanges();
        //}
    }
}
