using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
    class Department
    {
        private string dName;

        public string DepartmentName
        {
            get { return dName; }
            set { dName = value; }
        }
        private string dHead;

        public string DepartmentHead
        {
            get { return dHead; }
            set { dHead = value; }
        }
        private string dId;

        public string DepartmentId
        {
            get { return dId; }
            set { dId = value; }
        }
        private Course[] courses;
        private int courseCount;

        public int CourseCount
        {
            get { return courseCount; }
            set { courseCount = value; }
        }
        public Department()
        {
            courses = new Course[100];
        }
        public Department(string dName, string dHead, string dId)
        {
            this.dName = dName;
            this.dHead = dHead;
            this.dId = dId;
            courses = new Course[100];
            courseCount = 0;
        }
        public void addCourse(Course c)
        {
            if (courseCount < 100)
                courses[courseCount++] = c;
            else
                Console.WriteLine("Courses are full");
        }
    }
}
