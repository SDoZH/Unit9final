using System;


namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Student student = new Student { Name = "Tomgfhhdhsss", Age = 18, Phone = "+79251231212" };
                Exception[] exceptions = new Exception[5];
                exceptions[0] = new NaneException("Длина имени меньше 2 символов"); ;
                exceptions[1] = new AgeMin("Лицам до 18 регистрация запрещена");
                exceptions[2] = new AgeMax("Ты слишком старый");
                exceptions[3] = new PhoneEX("Не корректный номер");
                exceptions[4] = new MyExeptions1("Слишком длинное имя");

                if (student.Name == null || student.Name.Length < 2)
                {
                    throw exceptions[0];
                }
                if (student.Age < 18)
                {
                    throw exceptions[1];
                }
                if (student.Age > 23)
                {
                    throw exceptions[2];
                }
                if (student.Phone == null || student.Phone.Length != 12)
                {
                    throw exceptions[3];
                }
                if (student.Name.Length > 10)
                {
                    throw exceptions[4];
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
            catch (NotSupportedException ex)
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




