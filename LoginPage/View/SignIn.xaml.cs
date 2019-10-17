using System;
using System.Collections.Generic;
using LoginPage.ViewModel;
using Xamarin.Forms;

namespace LoginPage.View
{
    public partial class SignIn : ContentPage
    {
        private LoginViewModel loginViewModel;

        public SignIn()
        {
            loginViewModel = new LoginViewModel();
            InitializeComponent();
            BindingContext = loginViewModel;
        }
    }
}
