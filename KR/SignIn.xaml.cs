using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для Sign_In.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {

            InitializeComponent();
        }

        private void Button_SignIn_Click(object sender, RoutedEventArgs e)
        {

            string log = TextBoxLogin.Text.Trim();
            string pas = PasswordBox.Password.Trim();

            Users user = null;
            user = LogEntities.GetContext().Users.Where(b => b.Login == log && b.Password == pas).FirstOrDefault();


            if (user.Admin == true) 
            {
                MessageBox.Show("Ви успішно ввійшли, як адмін!");
                MainWindowAdmin mwa = new MainWindowAdmin();
                mwa.Show();
                Hide();
            }
            else if (user != null)
            {
                MessageBox.Show("Ви успішно ввійшли, як гість!");
                MainWindow mw = new MainWindow();
                mw.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Не вірний логін, або пароль.");
            }
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow fw = new FirstWindow();
            fw.Show();
            Hide();
        }

        private void Button_Guest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ви успішно ввійшли, як гість!");
            MainWindow mw = new MainWindow();
            mw.Show();
            Hide();

        }
    }
}
