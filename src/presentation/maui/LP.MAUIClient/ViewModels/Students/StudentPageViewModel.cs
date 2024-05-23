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

namespace LP.MAUIClient.ViewModels.Students
{
    public partial class StudentPageViewModel : BaseViewModel
    {
        private readonly IStudentService _studentService;
        public StudentPageViewModel()
        {
        }
        public StudentPageViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [ObservableProperty]
        List<Student> studentList = new();
        [ObservableProperty]
        private string search;
        public void ReloadList()
        {
            StudentList = _studentService.GetList(Search);
        }
        [RelayCommand]
        public async void GoToAddStudent()
        {
            await Shell.Current.GoToAsync(Routes.AddStudentPageRoute, new ShellNavigationQueryParameters
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
