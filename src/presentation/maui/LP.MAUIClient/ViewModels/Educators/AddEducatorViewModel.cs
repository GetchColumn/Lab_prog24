using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LP.Application.Common.Interfaces.Services;
using LP.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.MAUIClient.ViewModels.Educators
{
    public partial class AddEducatorViewModel: BaseViewModel
    {

        [ObservableProperty]
        private LP.Domain.Entities.Educator educator = new();
        private readonly IEducatorService _educatorService;
        public AddEducatorViewModel()
        {

        }
        public AddEducatorViewModel(IEducatorService educatorService)
        {
            _educatorService = educatorService;
        }
        [RelayCommand]
        public async Task AddEducator()
        {
            _educatorService.Add(new LP.Domain.Entities.Educator()
            {
                Id = Guid.NewGuid(),
                Name = educator.Name,
                Address = educator.Address,
                Age = educator.Age,
                Appointment = educator.Appointment,
                Department = educator.Department,
                WorkExperience = educator.WorkExperience
            });
            await Shell.Current.GoToAsync("..");
        }


    }
}
