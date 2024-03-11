using DependencyInjectionInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionInCSharp.BusinessClasses
{
    public class Account
    {
        private IAccount account;
        public Account(IAccount _account)
        {
            this.account = _account;
        }

        public void PrintAccounts()
        {
            account.PrintDetails();
        }
    }
}
