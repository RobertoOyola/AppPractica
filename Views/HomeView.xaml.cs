using AppPractica.ViewModels;
using System.Threading.Tasks;

namespace AppPractica.Views;

public partial class HomeView : ContentPage
{
	private readonly HomeViewModel _viewModel;
    public HomeView(HomeViewModel homeViewModel)
	{
		InitializeComponent();
		_viewModel = homeViewModel;
        BindingContext = _viewModel;

    }

    private async Task btnVerDetalle_Clicked(System.Object sender, System.EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(DetalleView));
    }
}