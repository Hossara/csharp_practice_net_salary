using System;

namespace csharp_practice_net_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">> Net Salary Calculator <<");

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("> Emplyee {0}", i + 1);

                Console.Write("name: "); string name = Console.ReadLine();
                Console.Write("salary: "); double salary = double.Parse(Console.ReadLine());

                salary = salary - (salary * 0.05);

                if(salary >= 3000000 && salary < 5000000) salary = salary - (salary * 0.1);
                else if(salary >= 5000000 && salary < 9000000) salary = salary - (salary * 0.12);
                else if(salary > 9000000) salary = salary - (salary * 0.15);

                printResult(name, salary);
            }

            Console.ReadKey();
        }

        static void printResult(string name, double salary)
        {
            Console.WriteLine("Employee {0} net salary : {1}", name, (int) salary);
            Console.WriteLine("<-------------------------->");
        }
    }
}
