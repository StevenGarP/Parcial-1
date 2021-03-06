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
    public partial class AdiviNum : ContentPage
    {
        public AdiviNum()
        {
            InitializeComponent();
        }
        private void AdivinarNumero_Clicked(object Sender,EventArgs e)
        {
            string resultado = Resultado.Text;
            string remov = resultado.Remove(resultado.Length -1);
            int resta = Convert.ToInt32(remov) - 4;
            Adivinado.Text = resta.ToString();
            Resultado.Text = "";
        }
    }
}