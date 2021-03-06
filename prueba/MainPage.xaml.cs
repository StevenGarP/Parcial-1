using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prueba
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonNumero_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdiviNum());
        }

        private void buttonCumpleaños_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdiviCumple());
        }
    }
}
