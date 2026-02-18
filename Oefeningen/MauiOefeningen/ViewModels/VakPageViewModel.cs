using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiOefeningen.ViewModels
{
    public partial class VakPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string voornaam, naam, locatie, lokaal, uitvoer;

        [ObservableProperty]
        DateTime datum;

        [ObservableProperty]
        int resultaat;

        public VakPageViewModel()
        {
            Voornaam = string.Empty;
            Naam = string.Empty;
            Locatie = string.Empty;
            Lokaal = string.Empty;
            Datum = DateTime.Now.Date;
            Resultaat = 0;
            Uitvoer = string.Empty;
        }

        [RelayCommand]
        public void ResultaatTonen()
        {
                string tekst = $"Welkom {Voornaam} {Naam}\n" +
                $"Je vast lokaal is {Lokaal} in {Locatie}\n" +
                $"Je eerste les is op {Datum}\n" +
                $"Je hoopt {Resultaat}/20 te scoren";

            Uitvoer = tekst;    
        }
    }
}
