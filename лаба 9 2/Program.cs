using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace лаба_9_2
{ 
// Базовый класс для пункта меню

// Пример использования меню
internal class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        Student student2 = new Student();
            
            do
            {
                Console.WriteLine("\n1) Ввод данных\n2) Часть 1\n3) Честь 2\n4) Честь 3\n5) Вывести данные о студентах\n6) Выход");
                int i = Functions.Input();

                switch (i)
                {
                    case 1: //ввод данных
                        bool flag = true;
                        
                        do
                        {
                            Console.WriteLine("\n1) Ручной ввод\n2) Рандомные данные\n3) Назад");
                            int j = Functions.Input();

                            switch (j)
                            {
                                case 1: //ручно ввод
                                    ImputData();
                                    break;
                                case 2: //ранодный ввод
                                    ImputDataRandom();
                                    break;
                                case 3:
                                    flag = false;
                                    break;
                                default:
                                    Console.WriteLine("Ошибка! Введите число от 0 до 4");
                                    break;
                            }
                        } while (flag);
                        break;
                       
                        
                    case 2: //часть 1
                        task1Manual();
                        break;
                    case 3: //часть 2
                        flag = true;
                        
                        do
                        {
                            Console.WriteLine("\n1) Унарные операции\n2) Операции приведения типа\n3) Бинарные операции\n4) Назад");
                            int j = Functions.Input();

                            switch (j)
                            {
                                case 1: //унарные

                                    Task2();
                                    break; // Операции приведения типа
                                case 2:
                                    Task22();
                                    break;
                                case 3:// Бинарные операции
                                    flag = true;
                                    do
                                    {
                                        Console.WriteLine("\n1) Новое имя\n2) Уменьшить гпа\n3) Назад");
                                        int k = Functions.Input();
                                        
                                        switch (k)
                                        {
                                            case 1: //унарные
                                                Console.WriteLine("Для первого студента");
                                                Student student4 =  Functions.CheckIfWord()+ student1;
                                                student4.Show();
                                                Console.WriteLine("Для второго студента");
                                                Student student5 = Functions.CheckIfWord() + student2;
                                                student5.Show();
                                                break;
                                            case 2://Операции приведения типа
                                                Console.WriteLine("Для первого студента");
                                                Student student3 = Functions.Input() + student1;
                                                student3.Show();
                                                Console.WriteLine("Для второго студента");
                                                Student student6 = Functions.Input() + student2;
                                                student6.Show();
                                                break;
                                            
                                             
                                            case 3:
                                                flag = false;
                                                break;
                                            default:
                                                Console.WriteLine("Ошибка! Введите число от 0 до 3");
                                                break;
                                        }
                                    } while (flag);
                                    break;
                                case 4:
                                    flag = false;
                                    break;
                                default:
                                    Console.WriteLine("Ошибка! Введите число от 0 до 4");
                                    break;
                            }
                        } while (flag);
                        break;
                    case 4: //3
                        
                        flag = true;
                        do
                        {

                            Console.WriteLine("\n1) Ручной ввод\n2) Рандомные данные\n3) Назад");
                            int m = Functions.Input();

                            switch (m) { 
                         
                                case 1: //уе
                                    Task31();
                                    break;
                                case 2://Операции приведения типа

                                    Task32();
                                    break;
                                case 3:
                                    flag = false;
                                    break;
                                default:
                                    Console.WriteLine("Ошибка! Введите число от 0 до 3");
                                    break;
                            }
                        } while (flag);

                        break;
                    case 5:
                        student1.Show();
                        student2.Show();
                        Console.WriteLine(Student.GetCount());
                        
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Введите число от 0 до 5");
                        break;
                }
            } while (true);


            void task1Manual()
            {
                Functions functions = new Functions(); 
                string result = student1.StudentComparison(student1, student2);
                Console.WriteLine(result);
            }
            
            void ImputData()
            {
                Functions functions = new Functions();
                

                Console.WriteLine("Введите имя, возраст, gpa - 1 студента");
                student1.SetStudent(Functions.CheckIfWord(), Functions.Input1(), Functions.InputDouble());
                Console.WriteLine("Введите имя, возраст, gpa - 2 студента");
                student2.SetStudent(Functions.CheckIfWord(), Functions.Input1(), Functions.InputDouble());

            }

             void ImputDataRandom()
            {
                

                Functions functions = new Functions();
                student1.SetStudent(Functions.GenerateRandomString(), Functions.GenerateRandomInt(), Functions.GenerateRandomDouble());

                student2.SetStudent(Functions.GenerateRandomString(), Functions.GenerateRandomInt(), Functions.GenerateRandomDouble());

            }

            void Task2()
            {
                
                
                student1++;
                student2++;
                Console.WriteLine("1 студент");
                Console.WriteLine("Имя: " +student1.GetName());
                Console.WriteLine("Возраст: " +student1.GetAge()+"\n");
                Console.WriteLine("2 студент");
                Console.WriteLine("Имя: "+student2.GetName());
                Console.WriteLine("Возраст: " + student2.GetAge());

            }
            void Task22()
            {

                Console.WriteLine("Первый студент на " + ((int)student1) + "курсе");
                Console.WriteLine("Второй студент на " + ((int)student2) + "курсе");
                if (student1 == true)
                {
                    Console.WriteLine("оценки удовлетворительны");
                }
                else { Console.WriteLine("оценки не удовлетворительны"); }
                if (student2 == true)
                {
                    Console.WriteLine("оценки удовлетворительны");
                }
                else { Console.WriteLine("оценки не удовлетворительны"); }

            }

            void Task31()
            {
                Console.WriteLine("1 коллекция");
                StudentArray s1 = new StudentArray(Functions.Input1(), true);

                s1.Show();
                Console.WriteLine("2 коллекция");
                StudentArray s2 = new StudentArray(s1);
                s2.Show();
                s1[0] = new Student("Gleb", 18, 5);
                Console.WriteLine("1 коллекция");
                s1.Show();
                Console.WriteLine("2 коллекция");
                s2.Show();
                try
                {
                    s2[100] = new Student("Egor", 19, 5);
                    Console.WriteLine(s2[100]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                int index = StudentArray.FindOldestStudent(s1);

                if (index != -1)
                {
                    Console.WriteLine("Старший студент с GPA > 8: " + s1[index].Name);
                }
                else
                {
                    Console.WriteLine("Нет старшего студента с GPA > 8");
                }
            }

            void Task32()
            {
                
                StudentArray s1 = new StudentArray(Functions.Input1());
                Console.WriteLine("1 коллекция");
                s1.Show();
                Console.WriteLine("2 коллекция");
                StudentArray s2 = new StudentArray(s1);
                s2.Show();
                
                s1[0] = new Student("Gleb", 18, 5);
                Console.WriteLine("1 коллекция");
                s1.Show();
                Console.WriteLine("2 коллекция");
                s2.Show();
                try
                {
                    s2[100] = new Student("Egor", 19, 5);
                    Console.WriteLine(s2[100]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                int index = StudentArray.FindOldestStudent(s1);

                if (index != -1)
                {
                    Console.WriteLine("Старший студент с GPA > 8: " + s1[index].GetName());
                }
                else
                {
                    Console.WriteLine("Нет старшего студента с GPA > 8");
                }
            }
        }
        
        }
    
}



