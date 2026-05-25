using MyConsoleApp;

BankAccount ac1 = new BankAccount("Nguyen Van A");
ac1.Deposit(1500000);
ac1.Withdraw(300000);
ac1.Withdraw(2000000);
BankAccount ac2 = new BankAccount("Nguyen Van Hoang");
ac2.OwnerName = "";
ac1.DisplayInfo();
ac2.DisplayInfo();