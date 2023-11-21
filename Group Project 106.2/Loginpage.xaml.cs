using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
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




namespace Group_Project_106._2
{
    /// <summary>
    /// Interaction logic for Loginpage.xaml
    /// </summary>
    /// 




    public delegate void LoginPageEvent();

    public partial class Loginpage : UserControl
    {

        public event LoginPageEvent Destoryed;



        public Loginpage()
        {
            InitializeComponent();
        }

        private void BackBtn(object sender, RoutedEventArgs e)
        {
            Destoryed?.Invoke();
        }

        private void SubmitBtn(object sender, RoutedEventArgs e)
        {

            User user = new User();

            user.username = username.Text;
            user.password = password.Text;


            using (IDbConnection connection = new SQLiteConnection(globals.source))
            {
                connection.Open();
                var x = connection.Query<User>("select * from Users");
                var y = x.ToList();

                bool loginSuccess = false;

                foreach (var item in y)
                {
                    loginSuccess = user.match(item);

                    if (loginSuccess)
                    {
                        globals.globalUser = item;
                        loginStatusText.Foreground = Brushes.Black;
                        loginStatusText.Text = "";

                        Destoryed?.Invoke();

                        break;
                    }
                }

                if (!loginSuccess) {
                    globals.globalUser = null;
                    loginStatusText.Foreground = Brushes.Red;
                    loginStatusText.Text = "Incorect Username or Password";

                }

                int stop = 0;
            }
        }
    }
}
