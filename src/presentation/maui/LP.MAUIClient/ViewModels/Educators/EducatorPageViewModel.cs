using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LP.Application.Common.Interfaces.Services;
using LP.Domain.Entities;
using LP.MAUIClient.Pages.Common;
using LP.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.MAUIClient.ViewModels.Educators
{
    public partial class EducatorPageViewModel : BaseViewModel
    {
        private readonly IEducatorService _educatorService;
        public EducatorPageViewModel()
        {
        }
        public EducatorPageViewModel(IEducatorService educatorService)
        {
            _educatorService = educatorService;
        }
        [ObservableProperty]
        List<Educator> educatorList = new();
        [ObservableProperty]
        private string search;
        public void ReloadList()
        {
            EducatorList = _educatorService.GetList(Search);
        }
        [RelayCommand]
        public async void GoToAddEducator()
        {
            await Shell.Current.GoToAsync(Routes.AddEducatorPageRoute, new ShellNavigationQueryParameters
    {
        { "Id", "test" }
    });
        }
        [RelayCommand]
        public void SearchList()
        {
            ReloadList();
        }
    }
}
