using System;
using System.Windows.Input;
using System.Windows.Navigation;

namespace WPF_NavigationWindow
{
    /// <summary>
    /// Interaction logic for ApplicationToolbar.xaml
    /// </summary>
    public partial class ApplicationToolbar 
    {
        public ApplicationToolbar()
        {
            InitializeComponent();
        }

        private void NavigationCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NavigationService service = NavigationService.GetNavigationService(this);
            service.Navigate(new Uri(e.Parameter.ToString(), UriKind.Relative));
        }
    }
}