namespace MyConsoleApp;

public class SavingsAccount : BankAccount
{
    public SavingsAccount(string ownerName, decimal interestRate) : base(ownerName)
    {
        InterestRate = interestRate;
    }
    public decimal InterestRate { get; set; }

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate / 100;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"So TK: {AccountNumber} | Chu TK: {OwnerName} | Loai: Savings | Lai suat: {InterestRate}% | So du: {Balance:#,##0} VND");
    }
}
