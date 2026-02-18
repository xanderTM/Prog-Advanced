namespace MauiOefeningen.Views;

public partial class VakPage : ContentPage
{
	public VakPage(VakPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}