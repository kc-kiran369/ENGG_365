using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagement.Tests
{
    class StudentRegistry
    {
        public static StudentRegistry Instance { get; } = new StudentRegistry();

        private List<Student> m_Students = new List<Student>();
        public int TotalStudents
        {
            get
            {
                return m_Students.Count;
            }
        }
        public StudentRegistry()
        {

        }
        public void AddStudent()
        {
            m_Students.Add(new Student());
        }
        public void OnStudentAdd()
        {
            //todo : update ui
        }
        public void RemoveStudent(int index)
        {
            m_Students.RemoveAt(index);
        }
        public void OnStudentRemove()
        {

        }
    }
}
