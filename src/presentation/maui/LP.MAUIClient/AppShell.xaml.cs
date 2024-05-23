using LP.MAUIClient.Pages;
using LP.MAUIClient.Pages.Common;
using LP.MAUIClient.Pages.Educators;
using LP.MAUIClient.Pages.HeadsOfDepartment;
using LP.MAUIClient.Pages.Students;

namespace LP.MAUIClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        public void RegisterRoutes()
        {
            Routing.RegisterRoute(Routes.MainRoute, typeof(MainPage));

            Routing.RegisterRoute(Routes.AddEducatorPageRoute, typeof(AddEducatorPage));
            Routing.RegisterRoute(Routes.EducatorPageRoute, typeof(EducatorPage));

            Routing.RegisterRoute(Routes.AddHeadOfDepartmentPageRoute, typeof(AddHeadOfDepartmentPage));
            Routing.RegisterRoute(Routes.HeadOfDepartmentPageRoute, typeof(HeadOfDepartmentPage));

            Routing.RegisterRoute(Routes.AddStudentPageRoute, typeof(AddStudentPage));
            Routing.RegisterRoute(Routes.StudentPageRoute, typeof(StudentPage));
        }
    }
}
