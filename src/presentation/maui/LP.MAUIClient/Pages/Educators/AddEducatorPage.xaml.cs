using LP.MAUIClient.ViewModels;
using LP.MAUIClient.ViewModels.Educators;

namespace LP.MAUIClient.Pages.Educators;

[QueryProperty(nameof(Id), "Id")]
partial class AddEducatorPage : ContentPage
{
    //public string Id { get; set; } // this string causes exception System.Reflection.AmbiguousMatchException
    private readonly AddEducatorViewModel _addEducatorViewModel;
    public AddEducatorPage(AddEducatorViewModel addEducatorViewModel)
    {
        InitializeComponent();
        BindingContext = _addEducatorViewModel = addEducatorViewModel;
    }
}