namespace PDFfile;

public class Calculations
{
    public double Income { get; set; }
    public double Expense { get; set; }
    public double Profit { get; set; }

    public Calculations (double income, double expense, double profit)
    {
        Income = income;
        Expense = expense;
        Profit = profit;
    }
}