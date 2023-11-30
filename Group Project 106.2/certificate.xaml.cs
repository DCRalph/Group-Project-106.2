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
    /// Interaction logic for certificate.xaml
    /// </summary>
    /// 

    public delegate void CertificatePageEvent();

    public partial class certificate : UserControl
    {

        public event CertificatePageEvent Destoryed;

        public certificate()
        {
            InitializeComponent();
        }

        private void backBtn(object sender, RoutedEventArgs e)
        {
            Destoryed?.Invoke();    
        }
    }
}
