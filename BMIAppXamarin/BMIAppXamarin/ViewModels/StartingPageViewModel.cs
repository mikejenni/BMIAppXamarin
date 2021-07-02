using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BMIAppXamarin.ViewModels
{


    class StartingPageViewModel
    {

        public ICommand StartBMI { get; }

        public StartingPageViewModel()
        {
            StartBMI = new Command(() => { Application.Current.MainPage = new BottomTab(); });
        }
    }
}
