using MauiApp1.ViewModels;
namespace MauiApp1.Views;


public partial class CatsDetailsPage : ContentPage
{
    public CatsDetailsPage(CatsDetailsViewModel catsDetailsViewModel)
    {
        InitializeComponent();
        BindingContext = catsDetailsViewModel;
    }
}