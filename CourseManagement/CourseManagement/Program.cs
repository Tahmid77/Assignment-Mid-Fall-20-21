using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department("CS","Mishu","404");
            Course c = new Course();
            c.CourseName = "OOP2";
            c.CourseID = "4014";
            c.CourseLength = 5;
            d.addCourse(c);
            Section s = new Section();
            s.SectionName = "a";
            c.addSection(s);
            Faculty f = new Faculty();
            f.TeacherName = "Tanvir Ahmed";
            f.TeacherId = "110114";
            Teacher t = f;
            s.addTeacher(t,c.CourseLength);
            Console.WriteLine("Section and Faculty details from Course object.");
            c.ShowDetalis(t,s);
            Console.WriteLine("Section details from Faculty object.");
            t.ShowSectionDetails(s);

        }
    }
}
