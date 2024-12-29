using Assignment04OOP01.Enums;

namespace Assignment04OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {//Assignment04C-OOP01

            //Part01

            //Gender gender = Gender.Female;
            //Console.WriteLine(gender);

            //Grades grade = Grades.A;
            //Console.WriteLine(grade);

            //Branch branch = Branch.Maadi;
            //Console.WriteLine(branch);



            #region Q1 Ex02   we have learned in the lecture.


            Student student = new Student();
            bool flage;
            Console.WriteLine("Please Enter Student Data..");
            Console.WriteLine("Id--> ");
            int id;
            do
            {

                flage =int.TryParse(Console.ReadLine(), out id);

            } while (!flage);

              student.Id = id;

            Console.WriteLine("Name--> ");
            student.Name = Console.ReadLine();


            Console.WriteLine("Gender--> ");
            object gender;
            do
            {

                flage = Enum.TryParse(typeof(Gender),Console.ReadLine(),true , out gender);

            } while (!flage);

            student.Gender = (Gender)gender;


            Console.WriteLine("Grade--> ");
            object grade;
            do
            {

                flage = Enum.TryParse(typeof(Grades), Console.ReadLine(),true ,out grade);

            } while (!flage);

            student.Grades = (Grades)grade;

            Console.WriteLine(student.Gender);


            Console.WriteLine("Branch--> ");
            object branch;
            do
            {

                flage = Enum.TryParse(typeof(Branch), Console.ReadLine(),true , out branch);

            } while (!flage);

            student.Branch = (Branch)branch;

            Console.WriteLine($" id = {student.Id} , Name = {student.Name} ,  Gender = {student.Gender}  ,  Grade {student.Grades}  , Branch = {student.Branch}");

            #endregion






        }
    }
}
