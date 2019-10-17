using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using LoginPage.View;


namespace LoginPage.ViewModel
{
    public class ImageViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        int sliderValue;
        string image;

        public int SliderValue
        {

            set
            {
                sliderValue = value;
                OnPropertyChanged(nameof(SliderValue));
                OnPropertyChanged(nameof(Images));

            }
            get
            {
                return sliderValue;
            }
        }

        public int DisplayNum
        {
            get
            {
                return sliderValue;
            }
        }



        public string Images
        {
            set
            {
                if (image != value)
                {
                    image = value;
                    OnPropertyChanged("Images");
                    OnPropertyChanged(nameof(DisplayNum));

                }
            }
            get
            {
                if (DisplayNum == 1)
                    return string.Format("Image1.png");
                else if (DisplayNum == 2)
                    return string.Format("Image2.png");
                else if (DisplayNum == 3)
                    return string.Format("Image3.png");
                else if (DisplayNum == 4)
                    return string.Format("Image4.png");
                else if (DisplayNum == 5)
                    return string.Format("Image5.png");
                else
                    return string.Format("Image1.png");
            }

        }

        public Command ButtonCommand
        {
            get
            {
                return new Command(PressButton);
            }
        }

        private void PressButton()
        {
            if (DisplayNum == 1)
                App.Current.MainPage.DisplayAlert("Image 1 is displayed", " ", "OK");
            else if (DisplayNum == 2)
                App.Current.MainPage.DisplayAlert("Image 2 is displayed", " ", "OK");
            else if (DisplayNum == 3)
                App.Current.MainPage.DisplayAlert("Image 3 is displayed", " ", "OK");
            else if (DisplayNum == 4)
                App.Current.MainPage.DisplayAlert("Image 4 is displayed", " ", "OK");
            else if (DisplayNum == 5)
                App.Current.MainPage.DisplayAlert("Image 4 is displayed", " ", "OK");
            else
                App.Current.MainPage.DisplayAlert("Image 1 is displayed", " ", "OK");

        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


