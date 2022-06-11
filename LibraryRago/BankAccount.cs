namespace LibraryRago
{
    public class BankAccount
    {
        public int balance { get; set; }
        private readonly ILoggerGeneral _loggerGeneral;
        public BankAccount(ILoggerGeneral loggerGeneral)
        {
            balance = 0;
            _loggerGeneral = loggerGeneral;
        }

        public bool Deposit(int mount)
        {
            _loggerGeneral.Message("Is depositing " + mount);
            balance += mount;
            return true;
        }

        public bool Withdrawal(int mount)
        {
            if (mount <= balance)
            {
                balance -= mount;
                return true;
            }
            return false;
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
