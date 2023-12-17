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
    /// Логика взаимодействия для Sign_Up.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_SignUp_Click(object sender, RoutedEventArgs e)
        {
            string log = TextBoxLogin.Text.Trim();
            string pas = PasswordBox.Password.Trim();
            string pas2 = PasswordBox2.Password.Trim();
            if (log.Length < 3) { MessageBox.Show("Занадто короткий логін"); PasswordBox2.Clear(); TextBoxLogin.Clear(); }
            else if (log.Length > 10) { MessageBox.Show("Занадто довгий логін"); TextBoxLogin.Clear(); PasswordBox2.Clear(); }
            else if (pas.Length < 3) { MessageBox.Show("Занадто короткий пароль"); PasswordBox.Clear(); PasswordBox2.Clear(); }
            else if (pas.Length > 10) { MessageBox.Show("Занадто довгий пароль"); PasswordBox.Clear(); PasswordBox2.Clear(); }
            else if (pas == pas2)
            {
                Users user = new Users();
                user.Login = log;
                user.Password = pas;
                user.Admin = false;

                LogEntities.GetContext().Users.Add(user);
                LogEntities.GetContext().SaveChanges();

                MessageBox.Show("Ви успішно зареєстровані!");

                FirstWindow fw = new FirstWindow();
                fw.Show();
                Hide();
            }
            else
            {
                PasswordBox2.Clear();
                MessageBox.Show("Паролі не співпадають");
            }

        }


        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Hide();
        }

        private void Button_SignUp_Admin_Click(object sender, RoutedEventArgs e)
        {
            string log = TextBoxLogin.Text.Trim();
            string pas = PasswordBox.Password.Trim();
            string pas2 = PasswordBox2.Password.Trim();
            if (log.Length < 3) { MessageBox.Show("Занадто короткий логін"); PasswordBox2.Clear(); TextBoxLogin.Clear(); }
            else if (log.Length > 10) { MessageBox.Show("Занадто довгий логін"); TextBoxLogin.Clear(); PasswordBox2.Clear(); }
            else if (pas.Length < 3) { MessageBox.Show("Занадто короткий пароль"); PasswordBox.Clear(); PasswordBox2.Clear(); }
            else if (pas.Length > 10) { MessageBox.Show("Занадто довгий пароль"); PasswordBox.Clear(); PasswordBox2.Clear(); }
            else if (pas == pas2)
            {
                Users user = new Users();
                user.Login = log;
                user.Password = pas;
                user.Admin = true;

                LogEntities.GetContext().Users.Add(user);
                LogEntities.GetContext().SaveChanges();

                MessageBox.Show("Ви успішно зареєстровані адміністратором!");
                FirstWindow fw = new FirstWindow();
                fw.Show();
                Hide();
            }
            else
            {
                PasswordBox2.Clear();
                MessageBox.Show("Паролі не співпадають");
            }

        }

    }
}
