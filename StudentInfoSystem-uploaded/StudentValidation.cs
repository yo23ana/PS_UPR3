using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            Student stud = null;

            if (user.facultyNumber == null)
            {
                return stud;
            }

            foreach (var student in new StudentData().TestStudents)
            {
                if (student.FacultyNumber == user.facultyNumber)
                    return student;
            }

            return stud;
        }
    }
}
