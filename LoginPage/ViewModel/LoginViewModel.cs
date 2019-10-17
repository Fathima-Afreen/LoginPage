using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using LoginPage.View;
using Xamarin.Forms;
namespace LoginPage.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public LoginViewModel()
        {

        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(this, "Email");
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(this, "Password");
            }
        }
        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }

        private void Login()
        {
            //null or empty field validation, check weather email and password is null or empty  
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                if (Email.Contains("@gmail.com") && Password.Length >= 6)
                {
                    App.Current.MainPage.Navigation.PushAsync(new ImageSlider());

                }
                else
                    App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
        }

        protected static void OnPropertyChanged(LoginViewModel instance, string propertyName)
        {
            instance.PropertyChanged?.Invoke(instance, new PropertyChangedEventArgs(propertyName));
        }
    }
}
