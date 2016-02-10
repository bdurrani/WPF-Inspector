﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChristianMoser.WpfInspector.UserInterface
{
    /// <summary>
    /// Interaction logic for ResourcesView.xaml
    /// </summary>
    public partial class ResourcesView : UserControl
    {
        public ResourcesView()
        {
            InitializeComponent();
            DataContext = new ResourcesViewModel();
        }
    }
}
