using MauiIntroductie.ViewModels;

namespace MauiIntroductie.Views;

public partial class VoorbeeldPage : ContentPage
{
	public VoorbeeldPage(PersoonViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}