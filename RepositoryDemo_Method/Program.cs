using RepositoryDemo_Method.Models;
using RepositoryDemo_Method.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDemo_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uow = new UnitOfWork();
            var deptRepo = uow.GetRepo<Department>();
            Console.WriteLine("Create & insert");
            var d1 = new Department(1, "IT");
            var d2 = new Department(2, "Marketing");
            var d3 = new Department(3, "Production");
            deptRepo.Add(d1);
            deptRepo.Add(d2);
            deptRepo.Add(d3);
            Console.WriteLine("Read");
            deptRepo.Get()
                .ToList()
                .ForEach(d => Console.WriteLine(d));
            Console.WriteLine("Update");
            d2.Name = "Sales";
            deptRepo.Update(d2);
            deptRepo.Get()
                .ToList()
                .ForEach(d => Console.WriteLine(d));
            Console.WriteLine("Delete");
            deptRepo.Delete(3);
            deptRepo.Get()
                .ToList()
                .ForEach(d => Console.WriteLine(d));
            Console.WriteLine("*******†***********************");
            Employee e1 = new Employee(1, "Abdur Rob", 1, new DateTime(2020, 5, 3));
            Employee e2 = new Employee(2, "Jasim Mia", 2, new DateTime(2019, 9, 1));
            Employee e3 = new Employee(3, "Montasir Babu", 1, new DateTime(2020, 2, 2));
            var empRepo = uow.GetRepo<Employee>();
            empRepo.Add(e1);
            empRepo.Add(e2);
            empRepo.Add(e3);
            Console.WriteLine("Read");

            empRepo.Get()

                .ToList()
                .ForEach(e => Console.WriteLine(e));
            Console.WriteLine("Update");

            e2.DepartmentId = 3;

            empRepo.Update(e2);
            empRepo.Get()
                .ToList()
                .ForEach(e => Console.WriteLine(e));
            Console.WriteLine("Delete");
            empRepo.Delete(3);
            empRepo.Get()
                .ToList()
                .ForEach(e => Console.WriteLine(e));

            Console.ReadKey();
        }
    }
}


