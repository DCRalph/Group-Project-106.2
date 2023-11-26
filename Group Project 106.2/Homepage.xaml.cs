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
using System.Data.SQLite;
using System.Data;
using Dapper;
using System.IO;

namespace Group_Project_106._2
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Window
    {
        Loginpage login_page = new Loginpage();
        Appointment appointment_page = new Appointment();
        Qr_Code qr_page = new Qr_Code();
        Confirmation confirmation_page = new Confirmation();
        Symptoms symptoms_page = new Symptoms();
     

        static string databaseFileName = "db.sqlite";
        static string source = $"Data Source={System.IO.Path.Combine(Directory.GetCurrentDirectory(), databaseFileName)}";
        public Homepage()
        {
            InitializeComponent();
               
        }



       
    }
}
