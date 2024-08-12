using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hire : Expenses
{
    public Hire(double gross, double tax, double[] arrExpenses, double pay)
    {
        this.gross = gross;
        this.tax = tax;
        this.arrExpenses = arrExpenses;
        this.pay = pay;
    }

    public override void display()
    {
        Console.WriteLine("Gross Income: " + gross.ToString("C2"));
        Console.WriteLine("Net Income: " + net().ToString("C2"));
        Console.WriteLine("Expenses");
        Console.WriteLine("Fuel: " + arrExpenses[0].ToString("C2"));
        Console.WriteLine("Insurance: " + arrExpenses[1].ToString("C2"));
        Console.WriteLine("Parking Fees: " + arrExpenses[2].ToString("C2"));
        Console.WriteLine("Maintenance: " + arrExpenses[3].ToString("C2"));
        Console.WriteLine("Hire Cost: " + pay.ToString("C2"));
        Console.WriteLine(" ");
        Console.WriteLine("Amount Left: " + amountLeft().ToString("C2"));
    }
}