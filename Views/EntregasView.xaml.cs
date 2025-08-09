namespace AppPractica.Views;

[QueryProperty(nameof(Texto), "par")]
public partial class EntregasView : ContentPage
{
	private readonly EntregasViewModel _viewModel;

	public string Texto { get; set; }
    public EntregasView()
	{
		InitializeComponent();
		lblTexto.Text = $"Hemos recibido el texto: {Texto}";
    }
}