using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure.OOP
{
    // Without OOP
    public class Merchant
    {
        public string Name;
        public string Email;
    }

    public class MerchantService
    {
        public void UpdateEmail(Merchant merchant, string email)
        {
            // Direct modification without validation or business rules
            merchant.Email = email;
        }
    }


    // With OOP - Encapsulation
    // Encapsulation is the practice of bundling data and method that operate on the data into a single unit (i.e within a class) while restricting direct access to some of its components
    // This usually achieved through private fields and public getters/setters
    // WHY: Encapsulation hides the internal state of an object and only expose controlled interface
    public class MerchantRefactored
    {
        // Controlled access to Email through the UpdateEmail method ensures validation
        // Protects the integrity of the data while allowing controlled modifications
        private string _name;
        private string _email;

        public MerchantRefactored(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public void UpdateEmail(string newEmail)
        {
            if (string.IsNullOrEmpty(_email)) throw new ArgumentNullException("Email cannot be empty");

            _email = newEmail;
        }
    }
}
