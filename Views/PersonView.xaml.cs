using System.Windows.Controls;
using CSharp.Lab02.ViewModels;

namespace CSharp.Lab02.Views
{

    public partial class DatePickerView : UserControl
    {
        public DatePickerView()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }

        private void TBoxSurname_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void TBoxEmail_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
