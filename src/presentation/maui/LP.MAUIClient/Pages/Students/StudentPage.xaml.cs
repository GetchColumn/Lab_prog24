using LP.MAUIClient.ViewModels;
using LP.MAUIClient.ViewModels.Students;

namespace LP.MAUIClient.Pages.Students;

public partial class StudentPage : ContentPage
{
    private readonly StudentPageViewModel _studentPageViewModel;
    public StudentPage(StudentPageViewModel studentPageViewModel)
    {
        InitializeComponent();
        BindingContext = _studentPageViewModel = studentPageViewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _studentPageViewModel.ReloadList();
    }
}