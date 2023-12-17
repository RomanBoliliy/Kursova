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
    /// Логика взаимодействия для CoachesAdmin.xaml
    /// </summary>
    public partial class CoachesAdmin : Window
    {
        public CoachesAdmin()
        {
            InitializeComponent();
            DGrid.ItemsSource = TestEntities.GetContext().Coach.ToList();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindowAdmin main = new MainWindowAdmin();
            main.Show();
            Hide();

        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            CoachAdd add = new CoachAdd(null);
            add.Show();
            Hide();

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            CoachAdd add = new CoachAdd((sender as Button).DataContext as Coach);
            add.Show();
            Hide();
        }
    }
}
