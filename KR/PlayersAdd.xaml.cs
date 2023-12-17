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
    /// Логика взаимодействия для PlayersAdd.xaml
    /// </summary>
    public partial class PlayersAdd : Window
    {
        private Player player = new Player();
        private Player previousPlayer = null;
        public PlayersAdd(Player selectedPlayer)
        {
            InitializeComponent();

            if (selectedPlayer != null) { player = selectedPlayer; previousPlayer = new Player(); previousPlayer = selectedPlayer; }

            DataContext = player;

        }


        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            if (previousPlayer == null)
            {
                TestEntities.GetContext().Player.Add(player);
                try
                {
                    TestEntities.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                TestEntities.GetContext().Player.Add(player);
                try
                {
                    TestEntities.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            PlayersAdmin playerAdmin = new PlayersAdmin();
            playerAdmin.Show();
            Hide();
        }
    }
}
