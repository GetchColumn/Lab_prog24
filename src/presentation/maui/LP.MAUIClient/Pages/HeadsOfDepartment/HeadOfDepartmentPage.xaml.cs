using LP.MAUIClient.ViewModels;
using LP.MAUIClient.ViewModels.HeadsOfDepartment;

namespace LP.MAUIClient.Pages.HeadsOfDepartment;

public partial class HeadOfDepartmentPage : ContentPage
{
    private readonly HeadOfDViewModel _headofdViewModel;
    public HeadOfDepartmentPage(HeadOfDViewModel headofdViewModel)
    {
        InitializeComponent();
        BindingContext = _headofdViewModel = headofdViewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _headofdViewModel.ReloadList();
    }
}