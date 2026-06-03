namespace MyConsoleApp;

public class BankAccount
{
    private static int _counter = 0;
    private string _ownerName = string.Empty;
    public BankAccount(string ownerName)
    {
        _counter++;
        AccountNumber = "ACC" + _counter.ToString().PadLeft(6, '0');
        OwnerName = ownerName;
        Balance = 0;
    }

    public string AccountNumber { get; init; }
    public string OwnerName
    {
        get => _ownerName;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _ownerName = value;
            }
        }
    }
    public decimal Balance { get; protected set; } = 0;

    public virtual void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"You have been deposit {amount}, now your balance are {Balance}.");
        }
        else
        {
            Console.WriteLine("You only can deposit amount lager than 0.");
        }
    }

    public virtual bool Withdraw(decimal amount)
    {
        Console.WriteLine($"Your withdraw request are {amount}.");
        if (amount > 0 && Balance >= amount)
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

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"So TK: {AccountNumber} | Chu TK: {OwnerName} | So du: {Balance:#,##0} VND");
    }
}
