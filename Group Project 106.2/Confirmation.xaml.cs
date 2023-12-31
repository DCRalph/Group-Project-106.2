﻿using System;
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
    /// Interaction logic for Confirmation.xaml
    /// </summary>


    public delegate void confirmPageEvent();

    public partial class Confirmation : UserControl
    {
    public event confirmPageEvent Destoryed;
        public Confirmation()
        {
            InitializeComponent();
        }

        private void BackBtn(object sender, RoutedEventArgs e)
        {
            Destoryed?.Invoke();
        }

        private void goHomeBtn(object sender, RoutedEventArgs e)
        {
            Destoryed?.Invoke();
        }
    }
}
