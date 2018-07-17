using Flames.model;
using Flames.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flames
{
	public partial class MainPage : ContentPage
	{
        MainPageViewModel vm;

        public MainPage() { 
            vm = new MainPageViewModel();
            BindingContext = vm;
            InitializeComponent();

        }


        async void OnFlamesClicked(object sender, EventArgs e) //Needs to be in view model using task instead
        {
           
           if (vm.PartnerName.Trim().Length == 0 || vm.Name.Trim().Length == 0)
            {
              var answer = await DisplayAlert("Alert", "Your Name and Partner Name should not be blank", "OK", "Cancel");

                if (answer)
                {
                    vm.ShouldDisplayContentView = false;
                }
            }
        }
    }

}
