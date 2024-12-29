using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment04OOP01.Enums;

namespace Assignment04OOP01
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public Grades Grades { get; set; }

        public Branch Branch { get; set; }


    }
}
