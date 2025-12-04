using System;

namespace BankExceptionDemo
{
    // Step 1: Create a custom exception for insufficient balance
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    class BankAccount
    {
        public double Balance { get; private set; }

        public BankAccount(double initialAmount)
        {
            Balance = initialAmount;
        }

        // Step 2: Withdrawal method that may throw custom exception
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientBalanceException(
                    $"Withdrawal failed! You tried to withdraw {amount}, but your balance is only {Balance}."
                );
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawal successful! Remaining balance: {Balance}");
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(5000);

            try
            {
                Console.WriteLine("Enter amount to withdraw: ");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out double withdrawAmount))
                {
                    Console.WriteLine("Please enter a valid numeric amount.");
                    return;
                }

                // Step 3: Call Withdraw (may throw our custom exception)
                account.Withdraw(withdrawAmount);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Custom Exception Caught!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Transaction Completed.");
            }
        }
    }
}
