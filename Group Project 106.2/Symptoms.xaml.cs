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
    /// Interaction logic for Symptoms.xaml
    /// </summary>
    /// 

    public delegate void symptomsPageEvent();

    public partial class Symptoms : UserControl
    {

        public event symptomsPageEvent Destoryed;

        public Symptoms()
        {
            InitializeComponent();

        }

        private void homeBtn(object sender, RoutedEventArgs e)
        {
            Destoryed?.Invoke();
        }

    }
}
