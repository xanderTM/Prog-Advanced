namespace MauiIntroductie.Views;

public partial class WerknemerPage : ContentPage
{
	public WerknemerPage(WerknemerViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}