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
    /// Interaction logic for adminPage.xaml
    /// </summary>
    /// 

    public delegate void adminPageEvent();

    public partial class adminPage : UserControl
    {

        public event adminPageEvent Logout;

        public adminPage()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Logout?.Invoke();
        }
    }
}
