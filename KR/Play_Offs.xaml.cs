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
    public partial class Play_Offs : Window
    {
        private List<Round_2> list_round2 = new List<Round_2>();
     
        private Round_2 _Current_Round_2 = null;
    
        private int i = 1;

        public Play_Offs()
        {
            InitializeComponent();

        }




        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Hide();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DGrid1.ItemsSource = TestEntities.GetContext().Round_1.Where(te => te.Low_Bucket == false && te.ID < 3).ToList();
            DGrid2.ItemsSource = TestEntities.GetContext().Round_1.Where(te => te.Low_Bucket == false && te.ID > 2 && te.ID < 5).ToList();
            DGrid3.ItemsSource = TestEntities.GetContext().Round_1.Where(te => te.Low_Bucket == true && te.ID > 4 && te.ID < 7).ToList();
            DGrid4.ItemsSource = TestEntities.GetContext().Round_1.Where(te => te.Low_Bucket == true && te.ID > 6).ToList();


            DGrid33.ItemsSource = TestEntities.GetContext().Round_2.Where(te => te.ID == 1 || te.ID == 3).ToList();
            DGrid44.ItemsSource = TestEntities.GetContext().Round_2.Where(te => te.ID == 2 || te.ID == 4).ToList();

            DGrid111.ItemsSource = TestEntities.GetContext().Round_3.Where(te => te.Low_Bucket == false).ToList();

            DGrid333.ItemsSource = TestEntities.GetContext().Round_3.Where(te => te.Low_Bucket == true).ToList();


            DGrid3333.ItemsSource = TestEntities.GetContext().Round_4.Where(te => te.ID == 1 || te.ID == 2).ToList();

            DGrid11111.ItemsSource = TestEntities.GetContext().Round_5.Where(te => te.ID == 1 || te.ID == 2).ToList();

            DGridW1.ItemsSource = TestEntities.GetContext().TournamensWinner.ToList();

        }
    }
}
