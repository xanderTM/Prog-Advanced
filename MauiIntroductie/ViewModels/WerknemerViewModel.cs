using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiIntroductie.ViewModels
{
    public partial class WerknemerViewModel : BaseViewModel
    {
        [ObservableProperty]
        Werknemer werknemer;

        [ObservableProperty]
        ObservableCollection<Werknemer> werknemers;

        public WerknemerViewModel()
        {
            this.Title = "Werknemer toevoegen";
            this.werknemers = [];
            this.Werknemer = new Werknemer();
        }

        [RelayCommand]
        private void WerknemerToevoegen()
        {
            this.Werknemers.Add(this.Werknemer);
            this.Werknemer = new Werknemer();
        }
    }
}
