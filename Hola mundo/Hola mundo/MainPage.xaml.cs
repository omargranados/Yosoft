﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Hola_mundo
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            Boton.Content = "HOLA MUNDO";
            Boton.Width = 200;
        }
        private void Boton2_Click(object sender, RoutedEventArgs e)
        {
            Boton2.Content = "ERROR!!!!!!!";
            Boton2.Height = 200;
        }
    }
}
