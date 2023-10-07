﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MoneyBankMVC.Models;

namespace MoneyBankMVC.Services
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAllAccountsAsync();
        Task<Account> GetAccountByIdAsync(int id);
        Task<bool> CreateAccountAsync(Account account);
        Task<bool> UpdateAccountAsync(Account account);
        Task<bool> DeleteAccountAsync(int id);
        Task<bool> DepositAsync(int id, decimal amount);
        Task<bool> WithdrawAsync(int id, decimal amount);
        Task<bool> IsAccountNumberAvailableAsync(string accountNumber);
    }
}
