using System;
using System.Collections.Generic;
using LoginPage.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginPage.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageSlider : ContentPage
    {
        private ImageViewModel imageViewModel;

        public ImageSlider()
        {
            imageViewModel = new ImageViewModel();
            InitializeComponent();
            BindingContext = imageViewModel;

        }
    }
}
