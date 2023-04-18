using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    [QueryProperty(nameof(Parameter), "Parameter")]
    [QueryProperty(nameof(CatSelected), "Action")]
    public partial class CatsDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        int[] _parameter;

        [ObservableProperty]
        Action<string> _catSelected;

        public CatsDetailsViewModel()
        {
        }

        [RelayCommand]
        private async Task NavigateBackAsync()
        {
            await Task.Delay(3000);
            await Shell.Current.GoToAsync("..", true);
            CatSelected?.Invoke("sergio");
        }

        partial void OnParameterChanged(int[] value)
        {
            Title = value[1].ToString();
        }

    }
}
