using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BuiltInInterfaces
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public int CompareTo(Student? other)
        {
            if (Score > other.Score)
            {
                return 1;
            }
            else if (Score < other.Score)
            {
                return -1;
            }
            return 0;
        }
    }

    public class ClassRoom : IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Sort()
        {
            students.Sort();
        }

        public List<Student> GetStudents() { 
            return students;
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var item in students)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
