using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
    class Section
    {
        private string sectionName;

        public string SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }
        Teacher teacher;
        public Section()
        {

        }
        public void addTeacher(Teacher t,int courseLength)
        {
            if (t.TeachingHour <= 21)
            {
                teacher = t;
                t.TeachingHour += courseLength;
            }

            else
                Console.WriteLine("Course limit reached");
        }
    }
}
