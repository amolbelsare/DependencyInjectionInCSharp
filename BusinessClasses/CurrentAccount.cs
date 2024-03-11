using DependencyInjectionInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionInCSharp.BusinessClasses
{
    public class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of CurrentAccount");
        }
    }
}
