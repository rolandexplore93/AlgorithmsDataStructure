using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure.OOP
{
    // BEFORE OOP
    public class PaymentService
    {
        public void ProcessPayment(string paymentType, decimal amount)
        {
            if (paymentType == "CreditCard") 
                Console.WriteLine("Processing Credit Card Payment");
            else if (paymentType == "PayPal")
                Console.WriteLine("Processing Payment Payment");
        }
    }


    // After OOP Abstraction
    public abstract class PaymentMethod
    {
        public abstract void ProcessPayment(decimal amount);

    }
    public class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card Payment of {amount}");
        }
    }

    public class PaypalPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Paypal Payment of {amount}");
        }
    }

    public class PaymentServiceNEW
    {
        // This abstract the logic for processing payments
        public void ProcessPayment(PaymentMethod paymentMethod, decimal amount)
        {
            paymentMethod.ProcessPayment(amount);
        }
    }
}
