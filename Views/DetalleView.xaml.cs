namespace AppPractica.Views;

public partial class DetalleView : ContentPage
{
	public DetalleView()
	{
		InitializeComponent();
		lblUsuario.Text = Preferences.Get("Usuario", "Invitado");
    }
}