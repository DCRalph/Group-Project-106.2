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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Destoryed?.Invoke();
        }

    }
}
