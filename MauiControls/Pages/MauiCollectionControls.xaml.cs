using MauiControls.Models;

namespace MauiControls.Pages;

public partial class MauiCollectionControls : ContentPage
{
	public MauiCollectionControls()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
	}

    private void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
		DisplayAlert("Alerta Cinto Segurança", "Voce selecionou/deselecionou este acessorio", "OK");
    }
}