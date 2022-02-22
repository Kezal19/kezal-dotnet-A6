public delegate string MyDelegate(); //declaring a delegate

class Account
{

    static int _accountNo;

    static int _balance;

    public Account(int accountNo, int balance)
    {
        _accountNo = accountNo;
        _balance = balance;
    }
    public int AccountNo
    {
        get => _accountNo;
    }

    public int Balance
    {
        get => _balance;
    }
    public static string Message()
    {
        if (_balance < 0)
        {
            return "you are overdrawn!\n";
        }
        else if (_balance < 50)
        {
            return "your account is very low!\n";
        }
        else if (_balance < 100)
        {
            return "watch your spending carefully!\n";
        }
        else
        {
            return "you have over $100 in your account!\n";
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        MyDelegate message = Account.Message;

        Account a1 = new Account(11011, 450);

        Console.WriteLine("\nAccount no.      Balance                   Message\n");

        Console.WriteLine("  " + a1.AccountNo + "           " + a1.Balance + "            " + message());

        Account a2 = new Account(11012, 75);

        Console.WriteLine("  " + a2.AccountNo + "            " + a2.Balance + "            " + message());

        Account a3 = new Account(11013, -12);

        Console.WriteLine("  " + a3.AccountNo + "           " + a3.Balance + "            " + message());

        Account a4 = new Account(11014, 35);

        Console.WriteLine("  " + a4.AccountNo + "            " + a4.Balance + "             " + message());

    }
}