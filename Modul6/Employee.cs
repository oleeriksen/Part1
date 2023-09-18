using System;
namespace Modul6
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int TaxDeduction { get; set; }
        public int TaxPrecentage { get; set; }

        public bool IsMemberOfLunch { get; set; } = false;
        public bool IsMemberGiftbox { get; set; } = false;

        public virtual int Salary { get; }

        public void PrintHeader() {
            Console.WriteLine(Name);
            Console.WriteLine(Address);
            Console.WriteLine(Email);
        }

        public virtual string NameOfType { get; }

        public virtual string SpecLine { get; }
        public virtual void PrintSalaryNote() {
            PrintHeader();
            Console.WriteLine($"Type: {NameOfType}");
            Console.WriteLine(SpecLine);
            Console.WriteLine($"Fradrag {TaxDeduction} kr");
            int taxToPay = (Salary - TaxDeduction) * TaxPrecentage / 100;
            int nettoPayment = Salary - taxToPay;
            string taxToPayTxt = String.Format("{0, 8}", taxToPay);
            Console.WriteLine($"Skat: {TaxPrecentage} % af {Salary - TaxDeduction} kr\t\t{taxToPayTxt} kr");
            if (IsMemberOfLunch)
            {
                double amount = 350;
                if (this is ParttimeEmployee) // 30% rabat på frokostordning
                    amount = 350 * 70 / 100;
                string lunchTxt = String.Format("{0, 8}", amount);
                Console.WriteLine($"Frokostordning\t\t\t{lunchTxt} kr"); ;
                nettoPayment = nettoPayment - (int)amount;
            }
            if (IsMemberGiftbox)
            {
                string presentTxt = String.Format("{0,8}", 30);
                Console.WriteLine($"Gavekassen\t\t\t {presentTxt} kr");
                nettoPayment = nettoPayment - 30;
            }
            string nettoTxt = String.Format("{0,8}", nettoPayment);
            Console.WriteLine($"Nettoløn\t\t\t{nettoTxt} kr");
            Console.WriteLine("===========================================");

        }
    }
}

