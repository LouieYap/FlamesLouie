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
		public MainPage() { 
            MainPageViewModel vm = new MainPageViewModel();
            BindingContext = vm;
            InitializeComponent();

        }
	}
}
