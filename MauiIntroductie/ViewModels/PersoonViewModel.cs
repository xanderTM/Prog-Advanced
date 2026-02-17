using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MauiIntroductie.ViewModels
{
  public partial class PersoonViewModel : BaseViewModel 
    {
        [ObservableProperty]
        public string naam;

        partial void OnNaamChanging(string value)
        {
            Shell.Current.DisplayAlert("Changing", naam, "ok");
        }
        
    }
}
