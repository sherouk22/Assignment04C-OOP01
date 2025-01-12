using Assignment04OOP01.Enums;

namespace Assignment04OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {//Assignment04C-OOP01

            //Part01

            #region Q1 Ex01   we have learned in the lecture.


            //Person person = new Person();

            //person.Id = 1;
            //person.Name = "sherouk";
            //person.Gender = Gender.Female;
            //Console.WriteLine(person.Gender);

            //Grades grades =Grades.A;

            //if (grades == Grades.A)
            //    Console.WriteLine("Excellecnt");
            //else
            //    Console.WriteLine("Good louk Next Time..");



            //Gender gender = Gender.Female;
            //Console.WriteLine(gender);

            //Grades grade = Grades.A;
            //Console.WriteLine(grade);

            //Branch branch = Branch.Maadi;
            //Console.WriteLine(branch);

            #endregion


            #region Q1 Ex02   we have learned in the lecture.


            //Student student = new Student();
            //bool flage;
            //Console.WriteLine("Please Enter Student Data..");
            //Console.WriteLine("Id--> ");
            //int id;
            //do
            //{

            //    flage =int.TryParse(Console.ReadLine(), out id);

            //} while (!flage);

            //  student.Id = id;

            //Console.WriteLine("Name--> ");
            //student.Name = Console.ReadLine();


            //Console.WriteLine("Gender--> ");
            //object gender;
            //do
            //{

            //    flage = Enum.TryParse(typeof(Gender),Console.ReadLine(),true , out gender);

            //} while (!flage);

            //student.Gender = (Gender)gender;


            //Console.WriteLine("Grade--> ");
            //object grade;
            //do
            //{

            //    flage = Enum.TryParse(typeof(Grades), Console.ReadLine(),true ,out grade);

            //} while (!flage);

            //student.Grades = (Grades)grade;

            //Console.WriteLine(student.Gender);


            //Console.WriteLine("Branch--> ");
            //object branch;
            //do
            //{

            //    flage = Enum.TryParse(typeof(Branch), Console.ReadLine(),true , out branch);

            //} while (!flage);

            //student.Branch = (Branch)branch;

            //Console.WriteLine($" id = {student.Id} , Name = {student.Name} ,  Gender = {student.Gender}  ,  Grade {student.Grades}  , Branch = {student.Branch}");

            #endregion

            //Part02

            #region  1.Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.

            //Console.WriteLine("Days of the Week:");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion


            #region   2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as  its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Enter a season :");
            //string input = Console.ReadLine();
            //string output = "";
            //if (Enum.TryParse(input, true, out Season season))
            //{

            //    switch (season)
            //    {
            //        case Season.Spring:
            //            output = "March to May";
            //            break;
            //        case Season.Summer:
            //            output = "June to August";
            //            break;
            //        case Season.Autumn:
            //            output = "September to November";
            //            break;
            //        case Season.Winter:
            //            output = "December to February";
            //            break;
            //    }
            //    Console.WriteLine($"The month range for {season} is: {output} ");
            //}
            //else
            //{
            //    Console.WriteLine(" Please enter Spring, Summer, Autumn, Winter");
            //}

            #endregion






        }
    }
}
