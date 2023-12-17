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
    /// Логика взаимодействия для GRoup_StagesAdmin.xaml
    /// </summary>
    public partial class Group_StagesAdmin : Window
    {
        public Group_StagesAdmin()
        {
            InitializeComponent();
            DGrid.ItemsSource = TestEntities.GetContext().Group_Stage.ToList();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindowAdmin main = new MainWindowAdmin();
            main.Show();
            Hide();

        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Group_StageAdd add = new Group_StageAdd((sender as Button).DataContext as Group_Stage);
            add.Show();
            Hide();
        }
    }
}
