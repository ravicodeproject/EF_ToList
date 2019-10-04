using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.ToList
{
    /*
     Model class reflect structure of the table
         */
    public class Employee
    {
        [Key]
        public int EmpId { get; set; } //Column is treated as a property
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
    }

    public class CompanyDBContext : DbContext
    {
        public CompanyDBContext(): base(@"data source=DESKTOP-GSLLMHA;integrated security=yes;initial catalog=company")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }

    public class RunProgram
    {
        public static void runToList()
        {
            CompanyDBContext db = new CompanyDBContext();
            List<Employee> emps = db.Employees.ToList();

            foreach(Employee e in emps)
            {
                Console.Write(e.EmpId);
                Console.Write(",");
                Console.Write(e.EmpName);
                Console.Write(",");
                Console.Write(e.Salary);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        public static void runWhere()
        {
            CompanyDBContext db = new CompanyDBContext();
            List<Employee> emps = db.Employees.Where(temp=>temp.Salary>7000).ToList();

            foreach (Employee e in emps)
            {
                Console.Write(e.EmpId);
                Console.Write(",");
                Console.Write(e.EmpName);
                Console.Write(",");
                Console.Write(e.Salary);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
