using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiOefeningen.ViewModels
{
    public partial class NaamTonenViewModel : ObservableObject
    {
        [ObservableProperty]
        string naam, resultaat;
        [ObservableProperty]
        int getal;

        public NaamTonenViewModel()
        {
            ResultaatLeegmaken();
        }

        [RelayCommand]
        public void NaamTonen()
        {
            string tekst = "Resultaat: ";

            for (int i = 0; i < Getal; i++)
            {
                tekst += Naam;

                if (i < Getal - 1)
                    tekst += ", ";
            }

            Resultaat = tekst;
        }

        [RelayCommand]
        public void ResultaatLeegmaken()
        {
            Naam = string.Empty;
            Getal = 0;
            Resultaat = string.Empty;
        }
    }
}
