namespace MauiIntroductie.Views;

public partial class FotoPage : ContentPage
{
	public FotoPage(FotoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}