namespace MyConsoleApp;

public sealed class CheckingAccount : BankAccount
{
    private const decimal OverdraftLimit = 500000;
    public CheckingAccount(string ownerName, decimal monthlyFee) : base(ownerName)
    {
        MonthlyFee = monthlyFee;
    }

    public decimal MonthlyFee { get; set; }

    public override void CalculateMonthlyInterest()
    {
        if (Balance >= MonthlyFee)
        {
            Balance -= MonthlyFee;
        }
        else
        {
            Console.WriteLine("Your balance don't enought to deductible monthly fees.");
        }
    }

    public override bool Withdraw(decimal amount)
    {
        Console.WriteLine($"Your withdraw request are {amount}.");
        if (amount > 0 && Balance + OverdraftLimit >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"You have been withdraw {amount}, now your balance are {Balance}.");
            return true;
        }
        else
        {
            Console.WriteLine("Your balance amount are not enought to withdraw.");
            return false;
        }
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"So TK: {AccountNumber} | Chu TK: {OwnerName} | Loai: Checkings | Phi GD: {MonthlyFee:#,##0} VND | So du: {Balance:#,##0} VND");
    }
}
