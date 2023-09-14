using System;
namespace Modul6
{
    public class ParttimeEmployee : Employee
    {
        public int HourlySalary { get; set; }
        public int Hours { get; set; }

        public override int Salary => HourlySalary * Hours;



    }
}

