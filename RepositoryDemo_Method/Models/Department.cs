using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDemo_Method.Models
{

    public class Department : IModel
    {
        public Department() { }
        public Department(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name}";
        }
    }
    public class Employee : IModel
    {
        public Employee() { }
        public Employee(int id, string name, int departmentId, DateTime joinDate)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentId = departmentId;
            this.JoinDate = joinDate;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public DateTime JoinDate { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Dept. Id: {DepartmentId} Join Date: {JoinDate:yyyy-MM-dd}";
        }
    }
}
