using System.Windows;

namespace kurs.Windows
{
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        public void OpenWindow(Window window)
        {
            window.Show();
            this.Hide();
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void RegisterButton_OnClick(object sender, RoutedEventArgs e)
        {
            OpenWindow(new RegisterWindow());
        }
    }
}