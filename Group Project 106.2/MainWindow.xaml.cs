﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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


        public UserControl1 uc = new UserControl1();
        public MainWindow()
        {
            InitializeComponent();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindowGrid.Children.Add(uc);
            uc.Destoryed += CloseScreen;
        }


        public void CloseScreen(UserControl1 uc1)
        {
            MainWindowGrid.Children.Remove(uc1);
            Console.WriteLine("remove");
        }

    
    }
}
