using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AbsoluteLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Clicked_Register(object sender, EventArgs e)
        {
            Navigation.PushAsync(new register());
        }
        private void About_Us(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About_us());
        }
    }
}
