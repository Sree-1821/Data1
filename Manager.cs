using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
   
    internal class Manager : Employee
        {



            public double FoodAllowance { get; set; }
            public double OtherAllowance { get; set; }
            public double TotalSalary { get; set; } = 0.0;



            //Calling base class No parameter Constructor
            public Manager() : base()
            {
                FoodAllowance = 0.0;
                OtherAllowance = 0.0;
            }
            //Calling base class's parameterized Constructor
            //and passing parameters of base class(Employee)
            //Using Base class Constructor
            public Manager(int id, String name, DateTime JoiningDt, Department department, double salary, double FoodAllowance, double OtherAllowance)
               : base(id, name, salary, JoiningDt, department)
            {



                this.FoodAllowance = FoodAllowance;
                this.OtherAllowance = OtherAllowance;
            }



            //Ovrriding CalculateSalary() method of base class(Enployee)



            public override double CalculateSalary()
            {
                TotalSalary = base.Salary + FoodAllowance + OtherAllowance;
                return TotalSalary;
            }



            //Overriding ToString Method for string representation of an object
            public override string ToString()
            {
                return base.ToString() + "\nFood Allowance = " + FoodAllowance + "\nOther Allowance = " + OtherAllowance + "\nTotal Salary = " + CalculateSalary();
            }
        }
    }

