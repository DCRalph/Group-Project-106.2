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
    /// Interaction logic for Appointment.xaml
    /// </summary>
    /// 


    public delegate void appointmentPageEvent();

    public partial class Appointment : UserControl
    {

        public event appointmentPageEvent Destoryed;
        public event appointmentPageEvent Booked;



        public Appointment()
        {
            InitializeComponent();
        }

        private void BackBtn(object sender, RoutedEventArgs e)
        {
            Destoryed?.Invoke();
        }

        private void BookedBtn(object sender, RoutedEventArgs e)
        {
            String appoitmentEmailStr = appoitmentEmail.Text;
            String appoitmentNameStr = appoitmentName.Text;
            String appoitmentPhoneStr = appoitmentPhone.Text;
            String appoitmentGenderStr = appoitmentGender.Text;


            List<string> errors = new List<string>();

            if (appoitmentEmailStr == null || appoitmentEmailStr == "")
            {
                errors.Add("Please enter a email");
            }

            if(appoitmentNameStr == null || appoitmentNameStr == "")
            {
                errors.Add("Please enter your name");
            }

            if (appoitmentPhoneStr == null || appoitmentPhoneStr == "")
            {
                errors.Add("Please enter your phone number");
            }

            if (appoitmentGenderStr == null || appoitmentGenderStr == "")
            {
                errors.Add("Please enter your gender");
            }

            appoitmentErrorBox.Text = "";

            foreach (String error in errors)
            {
                appoitmentErrorBox.Text += error + ".\n";
            }

            if (errors.Count == 0) {  
                using (IDbConnection connection = new SQLiteConnection(globals.source))
                {
                var data = new { name = appoitmentNameStr, email = appoitmentEmailStr, phone = appoitmentPhoneStr, gender = appoitmentGenderStr };
                    connection.Open();
                    string queryString = "INSERT INTO Appointments ('User Name', 'User Email', 'User Phone', 'User Gender') VALUES ( @name , @email , @phone , @gender )";

                    var x = connection.Execute(queryString, data);

                }


                Booked?.Invoke();

            }

        }

    }
}
