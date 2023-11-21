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


using System.Data.SQLite;
using System.Data;
using Dapper;
using System.IO;


 

namespace Group_Project_106._2
{


    public partial class MainWindow : Window
    {
        Loginpage login_page = new Loginpage();
        Appointment appointment_page = new Appointment();
        Qr_Code qr_page = new Qr_Code();
        Confirmation confirmation_page = new Confirmation();
        Symptoms symptoms_page = new Symptoms();

        



        static string databaseFileName = "db.sqlite";
        static string source = $"Data Source={System.IO.Path.Combine(Directory.GetCurrentDirectory(), databaseFileName)}";

        public MainWindow()
        {
            InitializeComponent();
             MainContent.Content = login_page;

            login_page.Destoryed += closeContent;
            confirmation_page.Destoryed += closeContent;
            qr_page.Destoryed += closeContent;
            appointment_page.Destoryed += closeContent;
            symptoms_page.Destoryed += closeContent;
            
            appointment_page.Booked += Booked_Appointment;

            userState.Text = "Loged Out";

            test();
        }


        //private void dbTest()
       // {
       //    using (IDbConnection connection = new SQLiteConnection(source))
           // {
               // connection.Open();
                //var output = connection.Query<Book>("select * from Books", new DynamicParameters());
               // var x = connection.Query<User>("select * from Users");
                //var y = x.ToList();

                //int stop = 0;

                //return output.ToList();
            //}
        //}

        private void closeContent()
        {
            if(MainContent.Content != null)
                MainContent.Content = null;

            if(globals.globalUser == null)
            {
                userState.Text = "Loged Out";
                logoutBtn.Visibility = Visibility.Hidden;
            } else
            {
                userState.Text = "Loged In as " + globals.globalUser.username;
                logoutBtn.Visibility = Visibility.Visible;

            }
        }

        private void LogoutBtn(object sender, RoutedEventArgs e)
        {
            globals.globalUser = null;


            userState.Text = "Loged Out";
            logoutBtn.Visibility = Visibility.Hidden;

        }

        private void Page1Btn(object sender, RoutedEventArgs e)
        {
            MainContent.Content = login_page;
        }

        private void Page2Btn(object sender, RoutedEventArgs e)
        {
            MainContent.Content = appointment_page;
        }

        private void Page3Btn(object sender, RoutedEventArgs e)
        {
            MainContent.Content = qr_page;
        }

        private void Page4Btn(object sender, RoutedEventArgs e)
        {
            MainContent.Content = confirmation_page;
        }
        private void Page5Btn(object sender, RoutedEventArgs e)
        {
            MainContent.Content = symptoms_page;
        }


        private void Booked_Appointment()
        {
            MainContent.Content = confirmation_page;
        }



        public void test()
        {
            string username = "test";
            string password = "12345";

            using (IDbConnection connection = new SQLiteConnection(globals.source))
            {
                connection.Open();
                string queryString = "select * from Users Where username = '" + username + "' and password = '" + password + "'";
                var x = connection.Query(queryString);
                if(x.Count() > 1)
                {
                    
                }
                var y = 0;
            }
        }
        //-------------------
    }
}
