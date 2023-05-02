using AumentoUsandoList.Models;
using System;
using System.Xml.Linq;

namespace AumentoUsandoList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de uma lista de Employeers e uma instancia da mesma, para utilizar seu métodos
            List<Employee> employees = new List<Employee>();
            Employee e = new Employee();

            //Cadastro irá receber um retorno do tipo Employee e irá ser adicionado na Lista
            //Employee cadastro = e.RegisterEmpoloyee();
            //employees.Add(cadastro);

            //Adição regular a Lista
            employees.Add(new Employee { Id = 0, Name = "Paulo", Salary = 700 });
            employees.Add(new Employee { Id = 3, Name = "Henrique", Salary = 500 });

            Regist(employees);

            //int index = int.Parse(Console.ReadLine());
            int index = 0;

            //employees[index].Salary += e.IncreseSalary(30, employees[index].Salary);
            employees[index].IncreseSalary(30);
            Console.WriteLine("The salary was increse!");
            Regist(employees);
        }

        public static void Regist(List<Employee> employees)
        {
            Console.Write("\nEmployeers Regist:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}