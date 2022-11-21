using System;

namespace ClassroomManagement.Tests
{
    internal class Student
    {
        public string Name { get; private set; }
        public int Rollno { get; private set; }
        public int Class { get; private set; }
        public Student()
        {
            Name = "Unnamed";
            Rollno = 0;
            Class = 0;
        }
        public Student(string _name, int _roll, int _class)
        {
            Name = _name;
            Rollno = _roll;
            Class = _class;
        }
        public void AssignData(string _name, int _roll, int _class)
        {
            Name = _name;
            Rollno = _roll;
            Class = _class;
        }
    }
}
