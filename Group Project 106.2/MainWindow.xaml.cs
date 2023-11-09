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
        //AccountScreen accScreen = new AccountScreen();
        public MainWindow()
        {
            InitializeComponent();
           // MainContent.Content = homeScreen;
        }

        private void closeContent()
        {
            if(MainContent.Content != null)
            {
                MainContent.Content = null;
            }
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = login_page;
            login_page.Destoryed += closeContent;
        }

        private void Account_Button_Click(object sender, RoutedEventArgs e)
        {
           // MainContent.Content = accScreen;
           closeContent();
        }
    }
}
