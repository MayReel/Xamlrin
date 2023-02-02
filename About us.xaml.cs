using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AbsoluteLayout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class About_us : ContentPage
	{
		public About_us ()
		{
			InitializeComponent ();
		}
		private void Return_Login(object sender, EventArgs e)
		{
            Navigation.PushAsync(new MainPage());
        }
    }
}