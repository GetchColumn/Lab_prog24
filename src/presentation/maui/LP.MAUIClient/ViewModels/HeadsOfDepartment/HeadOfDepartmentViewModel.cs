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

namespace LP.MAUIClient.ViewModels.HeadsOfDepartment
{
    public partial class HeadOfDViewModel : BaseViewModel
    {
        private readonly IHeadOfDService _headofdService;
        public HeadOfDViewModel()
        {
        }
        public HeadOfDViewModel(IHeadOfDService headofdService)
        {
            _headofdService = headofdService;
        }
        [ObservableProperty]
        List<HeadOfDepartment> headofdList = new();
        [ObservableProperty]
        private string search;
        public void ReloadList()
        {
            HeadofdList = _headofdService.GetList(Search);
        }
        [RelayCommand]
        public async void GoToAddHeadOfD()
        {
            await Shell.Current.GoToAsync(Routes.AddHeadOfDepartmentPageRoute, new ShellNavigationQueryParameters
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
