using LP.MAUIClient.ViewModels;
using LP.MAUIClient.ViewModels.Educators;

namespace LP.MAUIClient.Pages.Educators;

public partial class EducatorPage : ContentPage
{
    private readonly EducatorPageViewModel _educatorPageViewModel;
    public EducatorPage(EducatorPageViewModel educatorPageViewModel)
    {
        InitializeComponent();
        BindingContext = _educatorPageViewModel = educatorPageViewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _educatorPageViewModel.ReloadList();
    }
}