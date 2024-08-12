using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Buy : Expenses
{
    public double buyPrice;
    public double totalDeposit;
    public double interest;
    public double months;


    public Buy(double gross, double tax, double[] arrExpenses, double buyPrice, double totalDeposit, double interest, double months)
    {
        this.gross = gross;
        this.tax = tax;
        this.arrExpenses = arrExpenses;
        this.buyPrice = buyPrice;
        this.totalDeposit = totalDeposit;
        this.interest = interest;
        this.months = months;
        this.pay = loanPayment(buyPrice, totalDeposit, interest, months);
    }

    public double loanPayment(double buyPrice, double totalDeposit, double interest, double months)
    {
        double loanAmount = buyPrice - totalDeposit;
        double monthlyRate = interest / 12 / 100;

        return (loanAmount * monthlyRate) /
        (1 - Math.Pow(1 + monthlyRate, -months));
    }

    public void disapproved(double grossNum, double loanPay)
    {
        if (loanPay > (grossNum / 3))
        {
            Console.WriteLine("Loan is unlikely to be approved.");
        }
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
        Console.WriteLine("Loan Payment: " + pay.ToString("C2"));
        disapproved(gross, pay);
        Console.WriteLine(" ");
        Console.WriteLine("Amount Left: " + amountLeft().ToString("C2"));
    }
}