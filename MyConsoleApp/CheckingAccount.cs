namespace MyConsoleApp;

public class CheckingAccount : BankAccount
{
    public CheckingAccount(string ownerName, decimal transactionFee) : base(ownerName)
    {
        TransactionFee = transactionFee;
    }

    public decimal TransactionFee { get; set; } = 5000;

    public override bool Withdraw(decimal amount)
    {
        Console.WriteLine($"Your withdraw request are {amount}.");
        if (amount > 0 && Balance >= amount + TransactionFee)
        {
            Balance -= amount + TransactionFee;
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
        Console.WriteLine($"So TK: {AccountNumber} | Chu TK: {OwnerName} | Loai: Checkings | Phi GD: {TransactionFee:#,##0} VND | So du: {Balance:#,##0} VND");
    }
}
