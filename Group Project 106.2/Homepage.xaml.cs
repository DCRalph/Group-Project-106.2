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
    /// 

    public delegate void homePageEvent();

    public partial class Homepage : UserControl
    {

        public event confirmPageEvent Destoryed;
        public event confirmPageEvent _appointment;
        public event confirmPageEvent _qr;
        public event confirmPageEvent _confermation;
        public event confirmPageEvent _symptons;

        public Homepage()
        {
            InitializeComponent();
               
        }

        private void backBtn(object sender, RoutedEventArgs e)
        {
            Destoryed?.Invoke();
        }

        private void Home_page_appointment(object sender, RoutedEventArgs e)
        {
            _appointment?.Invoke();
        }

        private void Home_page_qr(object sender, RoutedEventArgs e)
        {
            _qr?.Invoke();
        }

        private void Home_page_confermation(object sender, RoutedEventArgs e)
        {
            _confermation?.Invoke();
        }

        private void Home_page_symptons(object sender, RoutedEventArgs e)
        {
            _symptons?.Invoke();
        }


    }
}
