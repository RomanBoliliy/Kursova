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
    /// Логика взаимодействия для Group_StageAdd.xaml
    /// </summary>
    public partial class Group_StageAdd : Window
    {
        private Group_Stage GR = new Group_Stage();
        private Group_Stage previousGR = null;
        public Group_StageAdd(Group_Stage group_stage)
        {
            InitializeComponent();
            GR = group_stage;
            DataContext = GR;
 
        }


        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            int q = 0, w = 0, ee = 0, r = 0, t = 0;

            if (p1.Text == null) { q = 0; }
            else { q = int.Parse(p1.Text); }
            if (p2.Text == null) { w = 0; }
            else { w = int.Parse(p2.Text); }
            if (p3.Text == null) { ee = 0; }
            else { ee = int.Parse(p3.Text); }
            if (p4.Text == null) { r = 0; }
            else { r = int.Parse(p4.Text); }
            if (p5.Text == null) { t = 0; }
            else { t = int.Parse(p5.Text); }



            GR.Place_1 = q;
            GR.Place_2 = w;
            GR.Place_3 = ee;
            GR.Place_4 = r;
            GR.Place_5 = t;

            try
            {
                TestEntities.GetContext().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            Group_StagesAdmin group_StageAdmin = new Group_StagesAdmin();
            group_StageAdmin.Show();
            Hide();

        }
    }
}
