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
    /// Логика взаимодействия для MainWindowAdmin.xaml
    /// </summary>
    public partial class MainWindowAdmin : Window
    {
        public MainWindowAdmin()
        {
            InitializeComponent();
        }

        private void Button_Team_Click(object sender, RoutedEventArgs e)
        {
            TeamsAdmin team = new TeamsAdmin();
            team.Show();
            Hide();
        }

        private void Button_Player_Click(object sender, RoutedEventArgs e)
        {
            PlayersAdmin players = new PlayersAdmin();
            players.Show();
            Hide();
        }

        private void Button_Coach_Click(object sender, RoutedEventArgs e)
        {
            CoachesAdmin coaches = new CoachesAdmin();
            coaches.Show();
            Hide();
        }

        private void Button_Group_Stage_Click(object sender, RoutedEventArgs e)
        {
            Group_StagesAdmin group = new Group_StagesAdmin();
            group.Show();
            Hide();
        }

    }
}
