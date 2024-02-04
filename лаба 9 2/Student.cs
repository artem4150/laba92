using System;
using System.Drawing;
using System.Security.Claims;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace лаба_9_2
{
	internal class Student
	{

        
        private string name;
        private int age;
        private double gpa;
        static int count = 0;

        public static int GetCount() { return count; }

        public void SetStudent(string Name, int Age, double Gpa)
        {
            name = Name;
            age = Age;
            gpa = Gpa;
            
        }
        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public Student()
        {
            Name = "";
            Age = 0;
            Gpa = 0;
            count++;
        }
        public Student(string N, int A, double G)
        {
            Name = N;
            Age = A;
            Gpa = G;
            count++;
        }
        public Student(Student s)
        {
            Name = s.Name;
            Age = s.Age;
            Gpa = s.Gpa;
            count++;

        }
        public int Age
        {
            get => age;
            set
            {
                // Количество рублей не может быть меньше 0
                if (value < 0)
                {
                    Console.WriteLine("Error!");
                    age = 0;
                }
                else age = value;
            }
        }

        public double Gpa
        {
            get => gpa;
            set
            {
                // Количество рублей не может быть меньше 0
                if (value < 0)
                {
                    Console.WriteLine("Error!");
                    gpa = 0;
                }
                else gpa = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                
                // Количество рублей не может быть меньше 0
                if (HasCharacters)
                {
                    Console.WriteLine("Error!");
                    name = "";
                }
                else name = value;
            }
        }
        public bool HasCharacters
        {
            get { return !string.IsNullOrEmpty(name); }
        }

        

        public void Show()
        {
            Console.WriteLine($"Имя: {Name}, возраст: {Age}, Gpa: {Gpa}.");
        }
        public string StudentComparison(Student student1, Student student2)
        {
            string name1 = student1.name;
            int age1 = student1.age;
            double gpa1 = student1.gpa;
            string name2 = student2.name;
            int age2 = student2.age;
            double gpa2 = student2.gpa;
            string result = name1 +" ";
            if (age1 > age2)
            {
                result += "старше ";
            }
            if (age1 == age2)
            {
                result += "ровесник ";
            }
            if (age1 < age2) { result += "младше "; }
            result += name2 + ". " + Convert.ToString(gpa1)+" " + name1;
            if (gpa1 > gpa2)
            {
                result += " выше ";
            }
            if (gpa1 == gpa2)
            {
                result += " равен ";
            }
            if (gpa1 < gpa2) { result += " ниже "; }
            result += Convert.ToString(gpa2) +" "+ name2;
            return result;
        }
        public static Student operator ++(Student student)
        {
            Student Result = new Student();
            
            Result.name = Functions.CapitalizeFirstLetter(student.GetName());
            
            Result.Age = student.Age;
            Result.Age++;
            return Result;
        }
        public static explicit operator int(Student s)
        {
            
            if (18 <= s.Age && s.Age <= 22)
            {
                return s.Age - 17;
            }
            return -1;
        }
        public static implicit operator bool(Student s)
        {
            
            return s.Gpa < 6;
        }
        public static Student operator +(int d, Student s)
        {
            s.Gpa -=d;
            
            return s;
        }
        public static Student operator +(string d, Student s)
        {

            s.name = d;
            return s;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, возраст: {Age}, Gpa: {Gpa}.";
        }
        public override bool Equals(object obj)
        {
            bool equals = true;
            if (obj is Student)
            {
                Student r = (Student)obj;
                equals &= (this.name == r.name) && (this.name == r.name);
                equals &= (this.age == r.age) && (this.age == r.age);
                equals &= (this.gpa == r.gpa) && (this.gpa == r.gpa);
            }
            return equals;
        }
    }
}

