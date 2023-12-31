﻿using System;
namespace Modul6
{
    public class Opgave6_1
    {
        public void Run()
        {
            PermanentEmployee anders = new PermanentEmployee
            {
                Name = "Anders And",
                Address = "byvej 12",
                Email = "peter@peter.com",
                TaxDeduction = 5000,
                TaxPrecentage = 32,
                MonthlySalary = 23000,
                IsMemberOfLunch = true,
                IsMemberGiftbox = false
            };
            ParttimeEmployee jens = new ParttimeEmployee
            {
                Name = "jens",
                Address = "byvej 14",
                Email = "jens@jens.com",
                TaxDeduction = 6700,
                TaxPrecentage = 54,
                HourlySalary = 123,
                Hours = 110
            };
            PermanentEmployee peter = new PermanentEmployee
            {
                Name = "peter",
                Address = "byvej 12",
                Email = "peter@peter.com",
                TaxDeduction = 5000,
                TaxPrecentage = 32,
                MonthlySalary = 23000,
                IsMemberOfLunch = false,
                IsMemberGiftbox = false
            };
            ParttimeEmployee gert = new ParttimeEmployee
            {
                Name = "Gert",
                Address = "byvej 14",
                Email = "jens@jens.com",
                TaxDeduction = 6700,
                TaxPrecentage = 54,
                HourlySalary = 100,
                Hours = 100,
                IsMemberOfLunch = true
            };

            List<Employee> mEmp = new List<Employee>
            {
                gert, peter, anders, jens
            };

            mEmp.Sort();

            /*foreach (Employee emp in mEmp)
            {
                Console.WriteLine($"{emp.Name}: brutto: {emp.Salary}");
                emp.PrintSalaryNote();
            }*/

            double res = 0;
            foreach (var enAnsat in mEmp)
                res += enAnsat.Salary;
            Console.WriteLine($"Samlet brutto {res}");
            res = 0;
            foreach (var enAnsat in mEmp)
            {
                Console.WriteLine($"{enAnsat.Name} skal betale {enAnsat.TaxToPay}");
                res += enAnsat.TaxToPay;
            }
            Console.WriteLine($"Ialt skal der betales {res} til skat");
        }


}
}

