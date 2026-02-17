using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiIntroductie.ViewModels
{
    public partial class NamenViewModel : BaseViewModel
    {
        [ObservableProperty]
        string naam;

        [ObservableProperty]
        ObservableCollection<string> namen;

        public NamenViewModel()
        {
            this.Title = "Namen toevoegen";
            this.Namen = [];
            //Naam = string.Empty;
        }

        [RelayCommand]
        private void NaamToevoegen()
        {
            this.Namen.Add(this.Naam);
            this.Naam = string.Empty;
        }
    }
}
