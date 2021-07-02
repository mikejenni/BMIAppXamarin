using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMIAppXamarin
{

    public partial class BottomTab : Xamarin.Forms.Shell
    {
        public BottomTab()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.BMICalculatorPage), typeof(Views.BMICalculatorPage));
            Routing.RegisterRoute(nameof(Views.BMISettingsPage), typeof(Views.BMISettingsPage));
            Routing.RegisterRoute(nameof(Views.BMISavingsPage), typeof(Views.BMISavingsPage));
            Routing.RegisterRoute(nameof(Views.BMIDetailPage), typeof(Views.BMIDetailPage));
        }
    }
}