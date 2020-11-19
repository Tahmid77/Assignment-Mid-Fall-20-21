using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
    class Teacher
    {
        protected string teacherName;

        public string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }
        protected string teacherId;

        public string TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }
        protected int teachingHour;

        public int TeachingHour
        {
            get { return teachingHour; }
            set { teachingHour = value; }
        }
        public Teacher()
        {
            teachingHour = 0;
        }
        public void ShowSectionDetails(Section s)
        {

            Console.WriteLine("Section: " + s.SectionName);
        }
    
}
}
