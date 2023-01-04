using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqProjects
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Employee> GetAllStudents()
        {
            List<Employee> listStudents = new List<Employee>();

            Employee Employee1 = new Employee
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };
            listStudents.Add(Employee1);

            Employee Employee2 = new Employee
            {
                ID = 102,
                Name = "Mary",
                Gender = "Female"
            };
            listStudents.Add(Employee2);

            Employee Employee3 = new Employee
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };
            listStudents.Add(Employee3);

            Employee Employee4 = new Employee
            {
                ID = 104,
                Name = "Steve",
                Gender = "Male"
            };
            listStudents.Add(Employee4);

            Employee Employee5 = new Employee
            {
                ID = 105,
                Name = "Pam",
                Gender = "Female"
            };
            listStudents.Add(Employee5);

            return listStudents;
        }
    }
}