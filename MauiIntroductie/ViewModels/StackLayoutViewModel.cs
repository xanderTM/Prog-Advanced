using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiIntroductie.ViewModels
{
    public partial class StackLayoutViewModel : BaseViewModel
    {
        [ObservableProperty]
        string naam, email, telefoon, uitvoer, geslacht;

        public StackLayoutViewModel()
        {
            Naam = string.Empty;
            Email = string.Empty;
            Telefoon = string.Empty;
            Uitvoer = string.Empty;
        }

        [RelayCommand]
        public void UitvoerTonen()
        {
            Uitvoer = $"Dag {Naam}, je emailadres is {Email}, je geslacht is {Geslacht} en ik kan je bellen op het nummer {Telefoon}.";
        }
    }
}
