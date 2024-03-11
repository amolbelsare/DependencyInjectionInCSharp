using DependencyInjectionInCSharp.BusinessClasses;
using DependencyInjectionInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount ca = new CurrentAccount();
            Account acc1 = new Account(ca);
            acc1.PrintAccounts();

            IAccount sa = new SavingAccount();
            Account acc2 = new Account(sa);
            acc2.PrintAccounts();

            Console.ReadLine();

        }
    }
}
