namespace Tumakov12
{
    enum AccType
    {
        Текущий_счет,
        Сберегательный_счет
    }

    class BankAcc
    {

        private static int numOfBankAccs;
        private decimal accBalance;
        readonly int accNum;
        readonly AccType bankAccType;

        public decimal AccBalance
        {
            get
            {
                return accBalance;
            }
        }

        public static bool operator ==(BankAcc firstBankAccount, BankAcc secondBankAccount)
        {
            return ((firstBankAccount.accNum == secondBankAccount.accNum) && (firstBankAccount.accBalance == secondBankAccount.accBalance) && (firstBankAccount.bankAccType == secondBankAccount.bankAccType));
        }

        public static bool operator !=(BankAcc firstBankAccount, BankAcc secondBankAccount)
        {
            return ((firstBankAccount.accNum != secondBankAccount.accNum) || (firstBankAccount.accBalance != secondBankAccount.accBalance) || (firstBankAccount.bankAccType != secondBankAccount.bankAccType));
        }

        public override bool Equals(object obj)
        {
            if (obj is BankAcc bankAccount)
            {
                if ((accNum == bankAccount.accNum) && (accBalance == bankAccount.accBalance) && (bankAccType == bankAccount.bankAccType))
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{bankAccType} №{accNum:D3} содержит {accBalance} рублей";
        }

        private void ChangeNumberOfBankAccounts()
        {
            numOfBankAccs++;
        }

        public bool MoreMoney(decimal withdrawalAmount)
        {
            if ((accBalance - withdrawalAmount > 0) && (withdrawalAmount > 0))
            {
                accBalance -= withdrawalAmount;
                return true;
            }

            return false;
        }

        public bool PutMoney(decimal depositedAmoun)
        {
            if (depositedAmoun > 0)
            {
                accBalance += depositedAmoun;
                return true;
            }

            return false;
        }

        public bool TransMoney(BankAcc withdrawalAccount, decimal withdrawalAmount)
        {
            if ((withdrawalAmount > 0) && (withdrawalAccount.AccBalance - withdrawalAmount > 0))
            {
                accBalance += withdrawalAmount;
                withdrawalAccount.accBalance -= withdrawalAmount;
                return true;
            }

            return false;
        }

        public BankAcc(decimal accBalance)
        {
            this.accBalance = accBalance;
            bankAccType = AccType.Текущий_счет;
            accNum = numOfBankAccs;
            ChangeNumberOfBankAccounts();
        }

        public BankAcc(AccType bankAccType)
        {
            this.bankAccType = bankAccType;
            accBalance = 0;
            accNum = numOfBankAccs;
            ChangeNumberOfBankAccounts();
        }

        public BankAcc(decimal accBalance, AccType bankAccType)
        {
            this.accBalance = accBalance;
            this.bankAccType = bankAccType;
            accNum = numOfBankAccs;
            ChangeNumberOfBankAccounts();
        }

        public BankAcc()
        {
            accBalance = 0;
            bankAccType = AccType.Текущий_счет;
            accNum = numOfBankAccs;
            ChangeNumberOfBankAccounts();
        }
    }
}
