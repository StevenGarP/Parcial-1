using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdiviCumple : ContentPage
    {
        public AdiviCumple()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string resultado = Result.Text;
            int resta = Convert.ToInt32(resultado) - 365;
            string dias = Convert.ToString(resta);
            if (resta <1000)
            {
                string dia = dias.Substring(0, 1);
                string mes = dias.Substring(1, 2);
                DisplayAlert("Su cumpleaños es", $"El dia de su cumpleaños es: {dia}, Y el Mes es: {mes}", "Aceptar");
                Result.Text = "";
            }
            else
            {
                string dia = dias.Substring(0, 2);
                string mes = dias.Substring(2, 2);
                DisplayAlert("Su cumpleaños es", $"El dia de su cumpleaños es: {dia}, Y el Mes es: {mes}", "Aceptar");
                Result.Text = "";
            }
            
        }
    }
}