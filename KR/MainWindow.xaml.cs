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

namespace KR
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Team_Click(object sender, RoutedEventArgs e)
        {
            Teams team = new Teams();
            team.Show();
            Hide();
        }

        private void Button_Player_Click(object sender, RoutedEventArgs e)
        {
            Players players = new Players();
            players.Show();
            Hide();
        }

        private void Button_Coach_Click(object sender, RoutedEventArgs e)
        {
            Coaches coaches = new Coaches();
            coaches.Show();
            Hide();
        }

        private void Button_Play_Off_Click(object sender, RoutedEventArgs e)
        {
            Play_Offs play_Offs = new Play_Offs();
            play_Offs.Show();
            Hide();
        }

        private void Button_Group_Stage_Click(object sender, RoutedEventArgs e)
        {
            Group_Stages group = new Group_Stages();
            group.Show();
            Hide();
        }
    }
}
