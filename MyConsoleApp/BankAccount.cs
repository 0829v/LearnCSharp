namespace MyConsoleApp;

public class BankAccount
{
    private static int _counter = 0;

    private string _accountNumber;
    public string AccountNumber { get => _accountNumber; }

    private string _ownerName;
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

    private decimal _balance = 0;
    public decimal Balance { get => _balance; }

    public BankAccount(string ownerName)
    {
        _counter += 1;
        string newAccountNumber = "ACC" + _counter.ToString().PadLeft(6, '0');
        _accountNumber = newAccountNumber;
        _ownerName = ownerName;
        _balance = 0;
    }

    public void Deposit(decimal amount)
    {
        Console.WriteLine($"Your deposit request are {amount}.");
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"You have been deposit {amount}, now your balance are {_balance}.");
        }
        else
        {
            Console.WriteLine("You only can deposit amount lager than 0.");
        }
    }

    public bool Withdraw(decimal amount)
    {
        Console.WriteLine($"Your withdraw request are {amount}.");
        if (amount > 0 && _balance >= amount)
        {
            _balance -= amount;
            Console.WriteLine($"You have been withdraw {amount}, now your balance are {_balance}.");
            return true;
        }
        else
        {
            Console.WriteLine("Your balance amount are not enought to withdraw.");
            return false;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Your information: \nAccount number: {_accountNumber} \nOwner name: {_ownerName} \nBalance: {_balance}");
    }
}
