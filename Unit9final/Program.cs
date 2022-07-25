using System;
using System.IO;
using System.Collections;
using Task1;
using System.Text.RegularExpressions;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Student student = new Student { Name = "Tom", Age = 18, Phone = "+7921231212" };
                if (student.Name == null || student.Name.Length < 2)
                {
                    throw new NaneException("Длина имени меньше 2 символов");
                }
                if (student.Age < 18)
                {
                    throw new AgeMin("Лицам до 18 регистрация запрещена");
                }
                if (student.Age > 23)
                {
                    throw new AgeMax("Ты слишком старый");
                }
                if (student.Phone == null || student.Phone.Length != 12)
                {
                    throw new PhoneEX("Не корректный номер");
                }
                Console.WriteLine("Добро пожаловать {0}", (student.Name));
            }
            catch (AgeMin ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (AgeMax ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (NaneException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (PhoneEX ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Конец");
            }
        }


        public class Student
        {

            public string Name { get; set; } = "";
            public int Age { get; set; }
            public string Phone { get; set; }
        }
    }
}




