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

namespace Group_Project_106._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 




    public partial class MainWindow : Window
    {
        Loginpage login_page = new Loginpage();
        Appointment appointment_page = new Appointment();
        Qr_Code qr_page = new Qr_Code();
        Confirmation confirmation_page = new Confirmation();



        public MainWindow()
        {
            InitializeComponent();
            // MainContent.Content = login_page;
            // login_page.Destoryed += closeContent;

            appointment_page.Booked += Booked_Appointment;
        }

        private void closeContent()
        {
            if(MainContent.Content != null)
                MainContent.Content = null;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainContent.Content = login_page;
            login_page.Destoryed += closeContent;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainContent.Content = appointment_page;
            appointment_page.Destoryed += closeContent;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainContent.Content = qr_page;
            qr_page.Destoryed += closeContent;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainContent.Content = confirmation_page;
            confirmation_page.Destoryed += closeContent;
        }


        private void Booked_Appointment()
        {
            closeContent();

            MainContent.Content = confirmation_page;
            confirmation_page.Destoryed += closeContent;

        }

    }
}
