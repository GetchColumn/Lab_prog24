using LP.MAUIClient.ViewModels;
using LP.MAUIClient.ViewModels.HeadsOfDepartment;

namespace LP.MAUIClient.Pages.HeadsOfDepartment;

[QueryProperty(nameof(Id), "Id")]
partial class AddHeadOfDepartmentPage : ContentPage
{
    //public string Id { get; set; } // this string causes exception System.Reflection.AmbiguousMatchException
    private readonly AddHeadOfDViewModel _addHeadOfDViewModel;
    public AddHeadOfDepartmentPage(AddHeadOfDViewModel addHeadOfDViewModel)
    {
        InitializeComponent();
        BindingContext = _addHeadOfDViewModel = addHeadOfDViewModel;
    }
}