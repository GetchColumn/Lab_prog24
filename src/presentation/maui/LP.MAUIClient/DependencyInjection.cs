using LP.Infrastructure;
using LP.MAUIClient.Pages;
using LP.MAUIClient.Pages.Educators;
using LP.MAUIClient.Pages.HeadsOfDepartment;
using LP.MAUIClient.Pages.Students;
using LP.MAUIClient.ViewModels;
using LP.MAUIClient.ViewModels.Educators;
using LP.MAUIClient.ViewModels.HeadsOfDepartment;
using LP.MAUIClient.ViewModels.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.MAUIClient
{
    public static class DependencyInjection
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddInfrastructure();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<MainPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<AddEducatorViewModel>();
            mauiAppBuilder.Services.AddSingleton<EducatorPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<AddHeadOfDViewModel>();
            mauiAppBuilder.Services.AddSingleton<HeadOfDViewModel>();
            mauiAppBuilder.Services.AddSingleton<AddStudentPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<StudentPageViewModel>();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
        {

            mauiAppBuilder.Services.AddSingleton<MainPage>();
            mauiAppBuilder.Services.AddSingleton<AddEducatorPage>();
            mauiAppBuilder.Services.AddSingleton<EducatorPage>();
            mauiAppBuilder.Services.AddSingleton<AddHeadOfDepartmentPage>();
            mauiAppBuilder.Services.AddSingleton<HeadOfDepartmentPage>();
            mauiAppBuilder.Services.AddSingleton<AddStudentPage>();
            mauiAppBuilder.Services.AddSingleton<StudentPage>();

            return mauiAppBuilder;
        }
    }
}
