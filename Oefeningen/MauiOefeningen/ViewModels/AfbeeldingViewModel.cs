using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiOefeningen.ViewModels
{
    public partial class AfbeeldingViewModel : ObservableObject
    {
        [ObservableProperty]
        int getal;
        [ObservableProperty]
        string resultaat;

        public AfbeeldingViewModel()
        {
            getal = 1;
            Resultaat = $"landschap{Getal}.jpg";
        }

        [RelayCommand]
        void VeranderAfbeelding()
        {
            Resultaat = $"landschap{Getal}.jpg";
        }

    }
}
