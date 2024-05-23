using LP.MAUIClient.Pages;
using LP.MAUIClient.Pages.Educators;
using LP.MAUIClient.Pages.HeadsOfDepartment;
using LP.MAUIClient.Pages.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.MAUIClient.Pages.Common
{
    public static class Routes
    {
        public static string MainRoute { get; } = nameof(MainPage);
        public static string AddEducatorPageRoute { get; } = nameof(AddEducatorPage);
        public static string EducatorPageRoute { get; } = nameof(EducatorPage);
        public static string AddHeadOfDepartmentPageRoute { get; } = nameof(AddHeadOfDepartmentPage);
        public static string HeadOfDepartmentPageRoute { get; } = nameof(HeadOfDepartmentPage);
        public static string AddStudentPageRoute { get;} = nameof(AddStudentPage);
        public static string StudentPageRoute { get; } = nameof(StudentPage);
    }
}
