using Acr.UserDialogs;
using BMIAppXamarin.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BMIAppXamarin.ViewModels
{
    class BMIDetailViewModel
    {
        private List<string> _rating;
        public event PropertyChangedEventHandler PropertyChanged;

        public BMIDetailViewModel()
        {
            Rating = new List<string>()
            {
                "Underweight: \nFrom 0 to 18.5",
                "Normal weight: \nFrom 18.5 to 24.9",
                "Overweight: \nFrom 24.9 to 29.9",
                "Obese: \nFrom 29.9 to 34.9",
                "Extremely Obese: \nAbove 35"

            };
        }
        public List<string> Rating
        {
            get { return _rating; }

            set
            {
                _rating = value;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")

        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
