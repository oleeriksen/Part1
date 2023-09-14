using System;
namespace Modul6
{
    public class PermanentEmployee : Employee
    {
        public int MonthlySalary { get; set; }

        public override int Salary => MonthlySalary;

        
    }
}

