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
            Booked?.Invoke();
        }
    }
}
