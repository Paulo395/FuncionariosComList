using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoUsandoList.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        //Método de cadastro que retorna a si mesmo com os dados cadastrados
        public Employee RegisterEmpoloyee()
        {
            Console.Write("Id: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Salary: ");
            Salary = double.Parse(Console.ReadLine());

            Employee employee = new Employee(Id,Name,Salary);

            return employee;
        }

        public void IncreseSalary(int porc)
        {
            double increse = (porc / 100) * Salary;
            Salary += increse;
        }

        public override string ToString()
        {
            return "\nId: " + Id + "\nName: " + Name + "\nSalary: " + Salary + "\n";
        }
    }
}
