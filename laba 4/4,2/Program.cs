using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Income
{
    public double Amount { get; set; }

    public abstract double CalculateTax();
}

public class SalaryIncome : Income
{
    public override double CalculateTax()
    {
        return Amount * 0.2; // 20% tax
    }
}

public class GiftIncome : Income
{
    public override double CalculateTax()
    {
        return Amount * 0.15; // 15% tax
    }
}

public class Person
{
    public List<Income> Incomes { get; set; }

    public Person()
    {
        Incomes = new List<Income>();
    }

    public void AddIncome(Income income)
    {
        Incomes.Add(income);
    }

    public double CalculateTotalTax()
    {
        return Incomes.Sum(i => i.CalculateTax());
    }

    public void SortTaxes()
    {
        Incomes = Incomes.OrderBy(i => i.CalculateTax()).ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        person.AddIncome(new SalaryIncome { Amount = 50000 });
        person.AddIncome(new GiftIncome { Amount = 10000 });

        Console.WriteLine("Total tax: " + person.CalculateTotalTax());

        person.SortTaxes();

        foreach (var income in person.Incomes)
        {
            Console.WriteLine("Tax for income of " + income.Amount + ": " + income.CalculateTax());
        }
    }
}
