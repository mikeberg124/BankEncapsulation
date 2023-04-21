namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount amount = new BankAccount();
            Console.WriteLine("How much do you want to put in?");
            var amountDeposit = double.Parse(Console.ReadLine());
            amount.Deposit(amountDeposit);

            Console.WriteLine($"Your balance is {amountDeposit}");

        }
    }
}
