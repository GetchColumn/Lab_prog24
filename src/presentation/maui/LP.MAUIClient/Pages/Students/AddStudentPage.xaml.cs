using LP.MAUIClient.ViewModels;
using LP.MAUIClient.ViewModels.Students;

namespace LP.MAUIClient.Pages.Students;

[QueryProperty(nameof(Id), "Id")]
partial class AddStudentPage : ContentPage
{
    //public string Id { get; set; } // this string causes exception System.Reflection.AmbiguousMatchException
    private readonly AddStudentPageViewModel _addStudentViewModel;
    public AddStudentPage(AddStudentPageViewModel addStudentViewModel)
    {
        InitializeComponent();
        BindingContext = _addStudentViewModel = addStudentViewModel;
    }
}