public class ExpenseTrackerService
{
    private List<ExpenseDto> expenses;

    public ExpenseTrackerService()
    {
        expenses = new List<ExpenseDto>();
    }

    public void AddExpense(string description, decimal amount)
    {
        expenses.Add(new ExpenseDto(description, amount, DateTime.Now));
    }

    public void ViewExpenses()
    {
        Console.WriteLine("Expenses:");
        foreach (ExpenseDto expense in expenses)
        {
            Console.WriteLine($"- {expense.Description}: {expense.Amount} on {expense.Date:yyyy-MM-dd}");
        }
    }

    public decimal GetTotalExpenses()
    {
        decimal total = 0;
        foreach (ExpenseDto expense in expenses)
        {
            total += expense.Amount;
        }
        return total;
    }
}