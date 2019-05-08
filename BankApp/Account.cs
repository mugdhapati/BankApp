using System;
using System.Collections.Generic;
using System.Text;

//this is a single line comment
/*herer
 * is
 * multi
 * line
 * comment
 * 
 * */

namespace BankApp
{
    enum AccountType
    {
        Checking,
        Savings,
        CD,
        Loan
    }
    /// <summary>
    /// Account that represents
    /// bank account here you can
    /// withdraw or deposit money
    /// </summary>
    class Account
    {


        #region Properties
        /// <summary>
        /// Unique number for the account
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// email address of the account holder
        /// </summary>
        public string EmailAddress { get; set; }
        public decimal Balance { get; private set; }

        public AccountType AccountType { get; set; }
        public DateTime CreatedDate { get; private set; }
        #endregion


        #region Constructor
        public Account()
        {
            //lastAccountNumber++;
            //AccountNumber = lastAccountNumber;

            CreatedDate = DateTime.Now;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        #endregion
    }
}
