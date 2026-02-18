namespace MauiOefeningen.Views;

public partial class AfbeeldingenPage : ContentPage
{
	public AfbeeldingenPage(AfbeeldingViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}