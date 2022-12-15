using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
   
    
        class SalesPerson : Employee
        {
            public double commission { get; set; }
            public double PetrolAllowance { get; set; }
            public double TotalSalary { get; set; }



            //Calling base class No parameter Constructor



            public SalesPerson() : base()
            {
                commission = 0.0;
                PetrolAllowance = 0.0;



            }



            //Calling base class's parameterized Constructor
            //and passing parameters of base class(Employee)
            //Using Base class Constructor



            public SalesPerson(int id, String name, DateTime JoiningDt, Department department, double salary, double commission, double PetrolAllowance)
                 : base(id, name, salary, JoiningDt, department)
            {
                this.commission = commission;
                this.PetrolAllowance = PetrolAllowance;
            }



            //Ovrriding CalculateSalary() method of base class(Enployee)



            public override double CalculateSalary()
            {
                TotalSalary = base.CalculateSalary() + commission + PetrolAllowance;
                return TotalSalary;
            }
            //Overriding ToString Method for string representation of an object



            public override string ToString()
            {
                return base.ToString() + "\nCommission = " + commission + "\nPetrol Allowance = " + PetrolAllowance + "\nTotal Salary = " + CalculateSalary();
            }
        }
    }

