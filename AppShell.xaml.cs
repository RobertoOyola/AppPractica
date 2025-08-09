using AppPractica.Views;
using System.Threading.Tasks;

namespace AppPractica
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetalleView), typeof(DetalleView));
            Routing.RegisterRoute(nameof(EntregasView), typeof(EntregasView));
        }

        private async Task MenuItem_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("http://grupoficoabad.com/");
        }

        private async Task TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Browser.OpenAsync("http://www.ilum.com.com/");
        }
    }
}
