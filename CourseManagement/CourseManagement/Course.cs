using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
    class Course
    {
        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        private string courseId;

        public string CourseID
        {
            get { return courseId; }
            set { courseId = value; }
        }
        private int courseLength;

        public int CourseLength
        {
            get { return courseLength; }
            set { courseLength = value; }
        }
        private Section[] sections;
        private int sectionCount;

        public int SectionCount
        {
            get { return sectionCount; }
            set { sectionCount = value; }
        }
        public Course()
        {
            sections = new Section[1000];
            sectionCount = 0;
        }
        public void addSection(Section s)
        {
            if (sectionCount < 15)
                sections[sectionCount++] = s;
            else
                Console.WriteLine("sections are full");
        }
        public void ShowDetalis(Teacher t,Section s)
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Length: " + courseLength);
            Console.WriteLine("Section: " + s.SectionName);
            Console.WriteLine("Faculty Name: " + t.TeacherName);
            Console.WriteLine("Faculty ID: " + t.TeacherId);
            Console.WriteLine("Teaching Hour: " + t.TeachingHour) ;


        }
    }
}
