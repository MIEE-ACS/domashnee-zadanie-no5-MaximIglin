using System;

namespace dz5
{
    public class IdGenerator
    {
        private static int id = 1;
        public static int newId()
        {
            return id++;
        }
    }
    class Program
    {
        public class Employe{
            public int id = 0;
            public float salary;
            public string name;
            public string position;
            public string department;
            public Employe(float sal, string first_name, string pos, string dep) {
                id = IdGenerator.newId();
                salary = sal;
                
                if (salary < 0) {
                    throw new Exception("Зарплата не может быть отрицательной");
                    salary = Math.Abs(sal);
                }
                name = first_name;
                position = pos;
                department = dep;
            }

        };
        static void Main(string[] args)
        {

                Employe[] employes = new Employe[] {
                    new Employe(80500, "Maxim", "Python Backend developer", "ПАО СБЕРБАНК"),
                    new Employe(140000, "Sano", "Java Backend Developer", "ПАО СБЕРБАНК"),
                    new Employe(60500, "Daniil", "Frontend Developer", "ПАО СБЕРБАНК"),
                    new Employe(130000, "Alexey", "Data-scientist", "ПАО СБЕРБАНК"),
                    new Employe(85010, "Evgeny", "dev-ops", "ПАО СБЕРБАНК"),
                    new Employe(700000, "Mikhail", "Product Owner", "ПАО СБЕРБАНК"),
                };
                foreach (var employe in employes)
                {
                    Console.WriteLine(
                        $"Работник {employe.id.ToString()}" +
                        $"\n Имя: {employe.name}" +
                        $"\n Должность: {employe.position}" +
                        $"\n Зарплата: {employe.salary}" +
                        $"\n Отделение: {employe.department}"
                        );
                Console.WriteLine("========================================================================");
                }
            }
    }
}
