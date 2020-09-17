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
using System.Windows.Shapes;

namespace WpfImportXML
{
    public partial class ClientWindows : Window
    {
        public Client Client { get; private set; }

        public ClientWindows(Client p)
        {
            InitializeComponent();
            Client = p;
            this.DataContext = Client;
        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
