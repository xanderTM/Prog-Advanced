using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiIntroductie.ViewModels
{
    public partial class LabelsViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string text, textColor;

        [ObservableProperty]
        public FontAttributes fontAttributes;

        [ObservableProperty]
        public int fontSize, padding;

        public LabelsViewModel()
        {
            this.FontSize = 40;
            this.Text = "JOE WANNES";
            this.FontAttributes = FontAttributes.Bold;
            this.TextColor = "#AABBCC";
            this.Padding = 40;
        }
    }
}
