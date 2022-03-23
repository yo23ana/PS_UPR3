using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentData
    {
        public List<Student> TestStudents { get; private set; }

        public StudentData()
        {
            Student student = new Student("Yoana", "Marinova", "Ivanova", "FCSE", "KSE", "Bachelor",
                                           Student.Status.certified, "121219009", 3, 1, 31);
            TestStudents.Add(student);
        }
    }
}
