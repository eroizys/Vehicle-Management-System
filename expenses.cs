using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Expenses {
  public double gross;
  public double tax;
  public double[] arrExpenses = new double[4];
  public double pay;


  public abstract void display();

  public double net() {
    return gross - tax;
  }

  public double amountLeft() {
    return net() - arrExpenses[0] - arrExpenses[1] - arrExpenses[2] - arrExpenses[3] - pay;;
  }

}
