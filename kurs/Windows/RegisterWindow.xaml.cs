using System.Windows;

namespace kurs.Windows
{
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
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
            OpenWindow(new AuthWindow());
        }

        private void RegisterButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}