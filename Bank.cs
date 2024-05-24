using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace FirstProject
{
   abstract class Bank
    {
    public abstract int GetBalance();
        
  }

    class BankA : Bank
     {
        private int bankA = 100;
        public override int GetBalance()
        {
            return bankA;
        }
    }

        class BankB : Bank
    {
         private int bankB = 150;
    
        public override int GetBalance()
        {
            return bankB;
        }
    }

        class BankC : Bank
    {
        private int bankC = 200;
        public override int GetBalance()
        {
            return bankC;
        }
    }
}