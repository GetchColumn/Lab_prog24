using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LP.Application.Common.Interfaces.Services;
using LP.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.MAUIClient.ViewModels.Students
{
    public partial class AddStudentPageViewModel : BaseViewModel
    {

        [ObservableProperty]
        private LP.Domain.Entities.Student student = new();
        private readonly IStudentService _studentService;
        public AddStudentPageViewModel()
        {

        }
        public AddStudentPageViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [RelayCommand]
        public async Task AddStudent()
        {
            _studentService.Add(new LP.Domain.Entities.Student()
            {
                Id = Guid.NewGuid(),
                Name = student.Name,
                Address = student.Address,
                Age = student.Age,
                MajorScore = student.MajorScore,
                Group = student.Group,
                Faculty = student.Faculty,
                YearOfStudy = student.YearOfStudy
            });
            await Shell.Current.GoToAsync("..");
        }
    }
}

