using KR;
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
    /// Логика взаимодействия для TeamsAdd.xaml
    /// </summary>
    public partial class TeamsAdd : Window
    {
        private Team team = new Team();
        private Team previousTeam = null;
        public TeamsAdd(Team selectedTeam)
        {
            InitializeComponent();

            if (selectedTeam != null) { team = selectedTeam; previousTeam = new Team(); previousTeam = selectedTeam; }

            DataContext = team;

        }


        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            if (previousTeam == null)
            {
                TestEntities.GetContext().Team.Add(team);
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
                try
                {
                    TestEntities.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            TeamsAdmin teamsAdmin = new TeamsAdmin();
            teamsAdmin.Show();
            Hide();


        }
    }
}
