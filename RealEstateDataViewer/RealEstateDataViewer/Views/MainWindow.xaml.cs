﻿using System.Windows;
using RealEstateDataViewer.Models;
using RealEstateDataViewer.ViewModels;

namespace RealEstateDataViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.WindowState = WindowState.Maximized;
            InitializeComponent();
        }
    }
}
