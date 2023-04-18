using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class CatsViewModel : BaseViewModel
    {
        public CatsViewModel()
        {
            Title = "Welcome to Cards Page!";
        }

        [RelayCommand]
        private async Task NavigateToDetailsAsync()
        {
            int[] arrayAsParameter = new int[] { 1, 2, 3 };
            Dictionary<string, object> parameters = new()
            {
                { "Parameter", arrayAsParameter },
                { "Action", (object)HandleUserSelection }
            };
            await Shell.Current.GoToAsync(nameof(CatsDetailsPage), true, parameters);
        }

        private async void HandleUserSelection(string userSelection)
        {
            string testMe = userSelection;
            await Shell.Current.CurrentPage.DisplayAlert("User Selection", testMe, "okay", "cancel");
        }
    }
}
