using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AbsoluteLayout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class register : ContentPage
	{
		public register ()
		{
			InitializeComponent ();
		}
		private void Return_Login(object sender, EventArgs e)
		{
            Navigation.PushAsync(new MainPage());
        }
    }
}