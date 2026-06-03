using MyConsoleApp;

List<BankAccount> accounts = new List<BankAccount>
{
    new SavingsAccount("Nguyen Van A", 6),
    new CheckingAccount("Tran Thi B", 10000),
    new HighYieldSavingsAccount("Le Van C", 6, 0.5m)
};

// Gửi tiền
accounts[0].Deposit(2000000);
accounts[1].Deposit(3000000);
accounts[2].Deposit(120000000);

// Tính lãi/phí hàng tháng
foreach (var acc in accounts)
    acc.CalculateMonthlyInterest();

// Rút tiền thấu chi
CheckingAccount checking = (CheckingAccount)accounts[1];
checking.Withdraw(3200000); // rút 3.2 triệu, số dư 3 triệu - phí tháng 10k? Thực tế sau khi trừ phí còn 2,990,000, rút 3.2 triệu => thấu chi 210k, ok

// Hiển thị
foreach (var acc in accounts)
    acc.DisplayInfo();

// Thử tạo lớp kế thừa CheckingAccount -> lỗi biên dịch
// public class PremiumChecking : CheckingAccount { } // Error CS0509