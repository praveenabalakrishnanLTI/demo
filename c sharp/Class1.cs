using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {   //member variable
        public string name;
       public int rollno;
        public long mobileno;
        public int age;
        public DateTime dob;
        public string location;
        public string gender;
        public int marks;
        public static void Main()
        {
            Class1 obj = new Class1();
            obj.AcceptDetails();
            //obj.DisplayDetails();
           
        }
        //methods of a class or member functions
        public void AcceptDetails()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            //char[] na = name.ToCharArray();
            int cnt = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsUpper(name[i]))
                {
                    cnt = cnt + 1;
                }
            }
            Console.WriteLine("The number of upper case in {0} is {1}", name, cnt);
        }
            Console.WriteLine("Enter your rollno");
            rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your mobileno");
            mobileno = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your date of birth");
            dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter your location");
            location = Console.ReadLine();

            Console.WriteLine("Enter your gender");
            gender = Console.ReadLine();

            Console.WriteLine("Enter your marks");
            marks = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Your name is:" +name);
            Console.WriteLine("Your rollno is: {0}", rollno);
            Console.WriteLine("Your mobileno is: {0}", mobileno);
            Console.WriteLine("Your age is: {0}",age);
            Console.WriteLine("Your date of birth is: {0}", dob.ToShortDateString());
            Console.WriteLine("Your location is:" + location);
            Console.WriteLine("Your gender is:" + gender);
            Console.WriteLine("Your marks is: {0}", marks);
        }
    }
}
