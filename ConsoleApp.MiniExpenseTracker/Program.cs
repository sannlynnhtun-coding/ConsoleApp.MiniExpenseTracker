using ConsoleApp.MiniExpenseTracker;

ExpenseTrackerService tracker = new ExpenseTrackerService();

bool running = true;
while (running)
{
    Console.WriteLine("\nExpense Tracker");
    Console.WriteLine("1. Add Expense");
    Console.WriteLine("2. View Expenses");
    Console.WriteLine("3. Total Expenses");
    Console.WriteLine("4. Exit");

    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            Console.Write("Enter expense description: ");
            string description = Console.ReadLine()!;
            Console.Write("Enter expense amount: ");
            decimal amount = decimal.Parse(Console.ReadLine()!);
            tracker.AddExpense(description, amount);
            Console.WriteLine("Expense added!");
            break;
        case "2":
            tracker.ViewExpenses();
            break;
        case "3":
            decimal total = tracker.GetTotalExpenses();
            Console.WriteLine($"Total Expenses: {total}");
            break;
        case "4":
            running = false;
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}