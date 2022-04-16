using System;
using System.Windows;
using CSharp.Lab02.Views;

namespace CSharp.Lab02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Content = new DatePickerView();
        }

        private void DatePickerView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}