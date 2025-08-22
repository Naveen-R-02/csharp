namespace bank_account
{
    public class Program
    {
        public static void Main(string[] args)
        {
            sales_acc s = new sales_acc();
            s.deposit(25000);
            s.withdraw(30000);
            s.interest(100, 5, 60);
        }
    }
}
