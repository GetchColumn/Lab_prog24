using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LP.Application.Common.Interfaces.Services;
using LP.Domain.Entities;
using LP.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.MAUIClient.ViewModels.HeadsOfDepartment
{
    public partial class AddHeadOfDViewModel : BaseViewModel
    {

        [ObservableProperty]
        private LP.Domain.Entities.HeadOfDepartment headofdepartment = new();
        private readonly IHeadOfDService _headofdepartmentService;
        public AddHeadOfDViewModel()
        {

        }
        public AddHeadOfDViewModel(IHeadOfDService headofdepartmentService)
        {
            _headofdepartmentService = headofdepartmentService;
        }
        [RelayCommand]
        public async Task AddHeadOfD()
        {
            _headofdepartmentService.Add(new LP.Domain.Entities.HeadOfDepartment()
            {
                Id = Guid.NewGuid(),
                Name = headofdepartment.Name,
                Address = headofdepartment.Address,
                Age = headofdepartment.Age,
                Department = headofdepartment.Department,
                NumOfEmployees = headofdepartment.NumOfEmployees,
                WorkExperience = headofdepartment.WorkExperience
            });
            await Shell.Current.GoToAsync("..");
        }


    }
}
