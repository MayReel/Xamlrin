using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.WebRequestMethods;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gallery : ContentPage
    {
        public Gallery()
        {
            InitializeComponent();
        }

        string[] j = new string[5] { "https://archives.bulbagarden.net/media/upload/a/a2/1007Koraidon.png", 
            "https://img.pokemondb.net/artwork/large/miraidon.jpg", 
            "https://img.pokemondb.net/artwork/large/sprigatito.jpg",
            "https://img.pokemondb.net/artwork/large/fuecoco.jpg",
            "https://img.pokemondb.net/artwork/large/quaxly.jpg"};
        int i = 0;

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           // lbl.Text = "กดแล้ว";

        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            if(e.Direction== SwipeDirection.Left)
            {
                img.Source = j[i];
                i++;
                if (i == 5)
                    i = 0;
            }
            if(e.Direction== SwipeDirection.Right)
            {
                img.Source = j[i];
                i--;
                if (i == -1)
                    i = 4;
            }
        }
    }
}