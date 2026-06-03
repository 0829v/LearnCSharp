namespace MyConsoleApp;

public class SavingsAccount : BankAccount
{
    public SavingsAccount(string ownerName, decimal annualInterestRate) : base(ownerName)
    {
        AnnualInterestRate = annualInterestRate;
    }
    public decimal AnnualInterestRate { get; set; }

    public override void CalculateMonthlyInterest()
    {
        Balance += Balance * (AnnualInterestRate / 100) / 12;
    }

    public sealed override void DisplayInfo()
    {
        Console.WriteLine($"So TK: {AccountNumber} | Chu TK: {OwnerName} | Loai: Savings | Lai suat: {AnnualInterestRate}% | So du: {Balance:#,##0} VND");
    }
}
