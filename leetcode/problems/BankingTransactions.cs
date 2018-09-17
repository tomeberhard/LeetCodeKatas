using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    /*
    transactions = [
      {"payee": "BoA", "amount": 132, "payer": "Chase"},
      {"payee": "BoA", "amount": 827, "payer": "Chase"},
      {"payee": "Well Fargo", "amount": 751, "payer": "BoA"},
      {"payee": "BoA", "amount": 585, "payer": "Chase"},
      {"payee": "Chase", "amount": 877, "payer": "Well Fargo"},
      {"payee": "Well Fargo", "amount": 157, "payer": "Chase"},
      {"payee": "Well Fargo", "amount": 904, "payer": "Chase"},
      {"payee": "Chase", "amount": 548, "payer": "Well Fargo"},
      {"payee": "Chase", "amount": 976, "payer": "BoA"},
      {"payee": "BoA", "amount": 872, "payer": "Well Fargo"},
      {"payee": "Well Fargo", "amount": 571, "payer": "Chase"}
    ]

    BoA -> 50 -> Chase
    Chase -> 30 -> BoA
    BoA -> 70 -> Chase

    BoA -> 90 -> Chase
    */

    /// <summary>
    /// Asked by our good friends at uubbeerr
    /// </summary>
    class BankingTransactions
    {

        private static void print(string s)
        {
            Console.Out.Write(s);
        }

        private static void printLine(string s)
        {
            Console.Out.WriteLine(s);
        }

        public class Transaction
        {
            public string payee;
            public decimal amount;
            public string payer;

            public Transaction(string name, decimal amt, string payer_)
            {
                payee = name;
                amount = amt;
                payer = payer_;
            }
        }

        public class Bank
        {
            public string name;

            public Dictionary<string, decimal> amounts;

            public Bank(string name_)
            {
                name = name_;
                amounts = new Dictionary<string, decimal>();
            }

            public void AddTransaction(Transaction t)
            {
                if (!amounts.Keys.Contains(t.payer))
                {
                    amounts.Add(t.payer, t.amount);
                }
                else
                {
                    amounts[t.payer] = amounts[t.payer] + t.amount;
                }
            }
        }

        static void RunExample(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */

            // create list of transactions
            List<Transaction> list = new List<Transaction>();

            list.Add(new Transaction("BoA", 132, "Chase"));
            list.Add(new Transaction("BoA", 827, "Wells Fargo"));
            list.Add(new Transaction("Well Fargo", 751, "BoA"));
            list.Add(new Transaction("Chase", 877, "Well Fargo"));
            list.Add(new Transaction("Chase", 548, "Well Fargo"));



            // reduce list
            Dictionary<string, Bank> Banks = new Dictionary<string, Bank>();

            foreach (Transaction t in list)
            {
                if (!Banks.Keys.Contains(t.payee))
                {
                    Banks.Add(t.payee, new Bank(t.payee));
                }
                Banks[t.payee].AddTransaction(t);
            }


            // print reduced list
            //foreach(Transaction t in list)
            //{
            //    print(t.payee + " -> " + t.amount + " -> " + t.payer);
            //}
            foreach (string bankName in Banks.Keys)
            {
                printLine(Banks[bankName].name);

                //print("    Number of payers: " + Banks[bankName].amounts.Count);
                foreach (string payer in Banks[bankName].amounts.Keys)
                {
                    //print(payer);   //Banks[bankName].name);    // + " -> " + Banks[bankName].amounts[payer] + " -> " + Banks[bankName].amounts[payer].payer);
                    printLine("    " + Banks[bankName].name + " -> " + Banks[bankName].amounts[payer] + " -> " + payer);
                }
                printLine("");
            }

            // I can't hea you... 
        }
    }
}
