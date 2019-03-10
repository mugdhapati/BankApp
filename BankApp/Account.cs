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
        #region Properties
        /// <summary>
        /// unique number for the account
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        ///  email address of the account holder
        /// </summary>
        public string EmailAddress { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
        public DateTime CreatedDate { get; set; }
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
