using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        double[] expenses = new double[4];
        double pay;

        Console.WriteLine("MotoFinance");

        Console.WriteLine("");

        Console.Write("Monthly Gross Income: ");
        double gross = Convert.ToDouble(Console.ReadLine());
        Console.Write("Monthly Tax Deduction: ");
        double tax = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");

        //1.fuel, 2.insurance, 3.parking fees, 4.maintenance
        Console.WriteLine("Enter Expenditures:");
        Console.Write("Fuel: ");
        expenses[0] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insurance: ");
        expenses[1] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Parking fees: ");
        expenses[2] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Maintenance: ");
        expenses[3] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");

        Console.Write("Would you like to (1)Buy or (2)Hire? ");
        string choice = Console.ReadLine();

        Console.WriteLine("");

        if (choice == "1")
        {
            Console.WriteLine("Enter Your Car Buy/Loan Details");
            Console.Write("Buy Price: ");
            double carPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Total Deposit: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Annual Interest Rate(%): ");
            double iRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Months To Pay(120-240): ");
            double months = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Buy buy = new Buy(gross, tax, expenses, carPrice, deposit, iRate, months);
            buy.display();
        }
        else if (choice == "2")
        {
            Console.Write("How much do you pay for hire? ");
            pay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Hire hire = new Hire(gross, tax, expenses, pay);
            hire.display();
        }





        //Console.ReadLine();
    }
}