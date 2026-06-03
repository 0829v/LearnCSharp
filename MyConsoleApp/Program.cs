using MyConsoleApp;

BankAccount account1 = new BankAccount("Nguyen Van A");
SavingsAccount account2 = new SavingsAccount("Tran Thi B", 5);
CheckingAccount account3 = new CheckingAccount("Le Van C", 5000);

List<BankAccount> bankAccounts = [account1, account2, account3];

foreach (var account in bankAccounts)
{
    account.Deposit(2000000);
}

account1.Withdraw(500000);

account2.Withdraw(300000);
account2.ApplyInterest();

account3.Withdraw(200000);

account1.DisplayInfo();
account2.DisplayInfo();
account3.DisplayInfo();