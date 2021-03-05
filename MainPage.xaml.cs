using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin_bindings4.Models;

namespace xamarin_bindings4
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public List<Cancion> Canciones { get; set; }
        public MainPage()
        {
            InitializeComponent();
            this.Canciones = new List<Cancion>();
            Cancion cancion = new Cancion()
            {
                Imagen = "https://i.ytimg.com/vi/TeILJ_M77wg/hqdefault.jpg"
                ,
                Titulo = "Historias de amor"
                ,
                Artista = "OBK"
            };
            this.Canciones.Add(cancion);
            cancion = new Cancion()
            {
                Imagen = "https://images.shazam.com/coverart/t55956251-b1329085532_s400.jpg"
                ,
                Titulo = "Dame veneno"
                ,
                Artista = "Los Chunguitos"
            };
            this.Canciones.Add(cancion);
            cancion = new Cancion()
            {
                Imagen = " http://img.desmotivaciones.es/201102/Melody7.jpg"
                ,
                Titulo = "El baile del gorila"
                ,
                Artista = "Melody"
            };
            this.Canciones.Add(cancion);

            this.canciones.ItemsSource = this.Canciones;
        }
    }
}
