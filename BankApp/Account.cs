using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    /// <summary>
    /// Account that represents
    /// BANK ACCOUNT here you can
    /// withdaraw or deposit money
    /// </summary>
    class Account
    {
        #region statics
        public static int lastaccountnumber = 0;
        #endregion

        #region Properties
        /// <summary>
        /// unique number for the account
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        ///  email address of the account holder
        /// </summary>
        public string EmailAddress { get; set; }
        public decimal Balance { get; private set; }
        public string AccountType { get; set; }
        public DateTime CreatedDate { get; private set; }
        #endregion
        #region Constructor
        public Account()
        {
            AccountNumber = ++lastaccountnumber;
            CreatedDate = DateTime.Now;
        }


        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        public void Deposit (decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount; 
        }
        /// <summary>
        /// Withdraw money from account
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw (decimal amount)
        {

            Balance -= amount;
        }
        #endregion
    }
}
