using System;
namespace DuringLessonToday
{
	public class StudentSevice
	{
		public string[] GetStudentInfoInRange(DateTime startDate, DateTime endDate)
		{
            
             
		}

		private Student[] StudetInfo()
		{
            Student student1 = new()
            {
                Name = "Elnur",
                Surname = "Safiyev",
                email = "elnurms@code.edu.az",
                birthday = new DateTime(07 / 08 / 2004)
            };

            Student student2 = new()
            {
                Name = "Vugar",
                Surname = "Aliyev",
                email = "vugarms@code.edu.az",
                birthday = new DateTime(07 / 08 / 1987)
            };

            Student student3 = new()
            {
                Name = "Ali",
                Surname = "Jafarov",
                email = "alims@code.edu.az",
                birthday = new DateTime(07 / 08 / 2009)
            };

            
            Student[] fulldata = { student1, student2, student3 };

            return fulldata;
        }
		
	}
}

