using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10Exercitii.Interface;
using Lab10Exercitii.PaymentMethod;

namespace Lab10Exercitii.PaymentMethod

{
    public abstract class Payment
    {
        public Cash Amount { get; private set; }

        public Payment(Cash amount)
        {
            Amount = amount;
        }

    
        public void ProcessPayment(double amount)
        {
          
        }
    }

    public interface IPos
    {
        void ContactFullPayment(double amount);
        void ContactlessPayment(double amount);
    }

    public class Pos : IPos
    {
        public void ContactFullPayment(double amount)
        {
            Console.WriteLine($"Inserting card...");
            Console.WriteLine($"Processing contact-full payment of ${amount}...");
            Console.WriteLine($"Remove card...");
            Console.WriteLine($"Printing receipt...\n");
        }

        public void ContactlessPayment(double amount)
        {
            Console.WriteLine($"Tapping card...");
            Console.WriteLine($"Processing contactless payment of ${amount}...");
            Console.WriteLine($"Printing receipt...\n");
        }
    }
}
    