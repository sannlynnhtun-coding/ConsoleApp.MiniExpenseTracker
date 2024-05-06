﻿// See https://aka.ms/new-console-template for more information
public class ExpenseDto
{
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

    public ExpenseDto(string description, decimal amount, DateTime date)
    {
        Description = description;
        Amount = amount;
        Date = date;
    }
}
