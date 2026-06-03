namespace MyConsoleApp;

public class HighYieldSavingsAccount : SavingsAccount
{
    public HighYieldSavingsAccount(string ownerName, decimal annualInterestRate, decimal bonusRate) : base(ownerName, annualInterestRate)
    {
        BonusRate = bonusRate;
    }

    public decimal BonusRate { get; set; }

    public override void CalculateMonthlyInterest()
    {
        base.CalculateMonthlyInterest();

        if (Balance > 100_000_000)
        {
            decimal bonus = Balance * (BonusRate / 100) / 12;
            Balance += BonusRate;
        }
    }
}
