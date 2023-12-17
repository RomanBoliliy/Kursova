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
    /// Логика взаимодействия для CoachAdd.xaml
    /// </summary>
    public partial class CoachAdd : Window
    {
        private Coach coach = new Coach();
        private Coach previousCoach = null;
        public CoachAdd(Coach selectedCoach)
        {
            InitializeComponent();

            if (selectedCoach != null) { coach = selectedCoach; previousCoach = new Coach(); previousCoach = selectedCoach; }

            DataContext = coach;

        }


        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            if (previousCoach == null)
            {
                TestEntities.GetContext().Coach.Add(coach);
                try
                {
                    TestEntities.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { 
            TestEntities.GetContext().Coach.Add(coach);
            try
            {
                TestEntities.GetContext().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

            CoachesAdmin coachAdmin = new CoachesAdmin();
            coachAdmin.Show();
            Hide();

        }
    }
}
