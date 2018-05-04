using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FutbolApp.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaMenu : ContentPage
	{
		public PaginaMenu ()
		{
			InitializeComponent ();
		}

        public async void Jugadores_Clicked(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new PaginaListaJugadores());
        }

        public async void Equipos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaListaEquipos());
        }

    }
}