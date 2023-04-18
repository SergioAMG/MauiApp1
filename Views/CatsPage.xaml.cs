using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class CatsPage : ContentPage
{
    public CatsPage(CatsViewModel catsViewModel)
    {
        InitializeComponent();
        BindingContext= catsViewModel;
    }
}