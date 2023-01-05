using Homework_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Practices
{
    internal class Student2List
    {
        private Student2[] arr;

        public Student2List()
        {
            arr = new Student2[0];
        }

        public void Add(Student2 student)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = student;
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
