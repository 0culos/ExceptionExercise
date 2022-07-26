using ExceptionsExercise.Entities.Exceptions;

namespace ExceptionsExercise.Entities
{
    internal class Account
    {
        public int NUmber { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            NUmber = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (WithdrawLimit <= amount)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else if (Balance <= amount)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
