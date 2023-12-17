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

namespace KR
{
    /// <summary>
    /// Логика взаимодействия для PlayersAdmin.xaml
    /// </summary>
    public partial class PlayersAdmin : Window
    {
        public PlayersAdmin()
        {
            InitializeComponent();
            DGrid.ItemsSource = TestEntities.GetContext().Player.ToList();
        }



        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindowAdmin main = new MainWindowAdmin();
            main.Show();
            Hide();

        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            PlayersAdd add = new PlayersAdd(null);
            add.Show();
            Hide();

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            PlayersAdd add = new PlayersAdd((sender as Button).DataContext as Player);
            add.Show();
            Hide();
        }
    }
}
