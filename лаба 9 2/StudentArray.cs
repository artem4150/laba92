using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace лаба_9_2
{
	class StudentArray
	{
		Student[] studentarray;
        static Random rnd = new Random();
		public int Length
		{
			get => studentarray.Length;
		}

		public void Show()
		{
			for (int i = 0; i < studentarray.Length; i++)
			{
				studentarray[i].Show();
            }
        }
        public StudentArray(int length)
        {
            studentarray = new Student[length];
            for (int i = 0; i < length; i++)
            {
                studentarray[i] = new Student(Functions.GenerateRandomString(),rnd.Next(50), rnd.Next(50));
            }
        }
        //public Student[] StudentArrayManual(int length)
        //{
        //    studentarray = new Student[length];
        //    for (int i = 0; i < length; i++)
        //    {
        //        Console.WriteLine($"Введите имя, возраст, gpa - {i}  студента");
        //        studentarray[i] = new Student(Functions.CheckIfWord(), Functions.Input(), Functions.InputDouble());
        //    }
        //    return studentarray;
        //}

        public StudentArray(int length,bool m)
        {
            studentarray = new Student[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Введите имя, возраст, gpa - {i}  студента");
                studentarray[i] = new Student(Functions.CheckIfWord(), Functions.Input(), Functions.InputDouble());
            }
            
        }

        public StudentArray(StudentArray other)
        {
            this.studentarray = new Student[other.Length];
            for (int i = 0; i < other.Length; i++)
                this.studentarray[i] = other.studentarray[i];
        }

        public Student this[int index]
        {
            get
            {
                if (0 <= index && index < studentarray.Length)
                    return studentarray[index];
                else
                    throw new Exception("Индекс выходит за пределы коллекции");
                
            }
            set
            {
                if (0 <= index && index < studentarray.Length)
                    studentarray[index] = value;
                else
                    Console.WriteLine("Индекс выходит за пределы коллекции");
            }
        }


        public StudentArray()
        {
            studentarray = new Student[0];
        }

        public static int FindOldestStudent(StudentArray students)
        {
            int maxAge = -1;
            int index = -1;
            bool found = false;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Gpa > 8 && students[i].Age > maxAge)
                {
                    maxAge = students[i].Age;
                    index = i;
                    found = true;
                }
            }

            if (!found)
            {
                return -1;
            }

            return index;
        }
        
    }
}

