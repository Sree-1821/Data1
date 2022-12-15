using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
   
        public enum Department
        {
            HR, ACCOUNTS, PRODUCTION, PACKING, DISPATCH, SALES
        }
        internal class Employee
        {



            public int ID { get; set; }
            public String Name;
            public Department department;
            //emp has to define date of joining using Date
            public DateTime  JoiningDt;
            public double Salary;
            public static int EmployeeCount = 0;//static member variable



            //emp has to define date of joining



            //default constructor
            public Employee()
            {
                ID = 0;
                Name = "";
                department = Department.HR;
                JoiningDt = new DateTime(10, 10, 2021);
                Salary = 0.0;
                EmployeeCount += 1;
            }
            //Parameterized constructor
            public Employee(int id, String name, double salary, DateTime JoiningDt, Department department)
            {
                this.ID = id;
                this.Name = name;
                this.department = department;
                this.JoiningDt = JoiningDt;
                this.Salary = salary;
                EmployeeCount += 1;
            }
            public override string ToString()
            {
                return "\nEmployee Id = " + ID + "\nEmployee Name = " + Name + "\nDate of Joining = " + JoiningDt + "\nDepartment = " + department + "\nBasic Salary = " + Salary;
            }



            //Salary calculation
            public virtual double CalculateSalary()
            {
                return Salary;
            }
        }
}
