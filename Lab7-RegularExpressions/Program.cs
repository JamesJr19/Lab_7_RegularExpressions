using System;
using System.Text.RegularExpressions;

namespace Lab7_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for name and store as a variable
            string name = GetUserInput("What is your first name?");
            string nameAccepted = (ValidateName(name));
            Console.WriteLine(nameAccepted);

            //ask user for email and store as a variable
            string email = GetUserInput("What is your email address?");
            string emailAccepted = (ValidateEmail(email));
            Console.WriteLine(emailAccepted);

            //ask user for phone number and store as a variable
            string phoneNumber = GetUserInput("What is your phone number? ex (111-111-1111)");
            string phoneNumberAccepted = (ValidatePhone(phoneNumber));
            Console.WriteLine(phoneNumberAccepted);

            //ask user for birthday and store as a variable
            string birthday = GetUserInput("What is your date of birth? (dd/mm/yyyy)");
            string birthdayAccepted = (ValidateBirthday(birthday));
            Console.Write(birthdayAccepted);

            Console.WriteLine("");
            Console.WriteLine("Thank you. Have a good day!");
            
        }

        //method to get the user input
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        //Validate name input
        public static string ValidateName(string name)
        {
            //must start with capital letter and be no longer than 30 characters
            if (Regex.IsMatch(name, @"^[A-Z][a-z]{1,30}$"))
            {
                return $"Thank you {name}.\n";
            }
            else
            {
                return ValidateName(GetUserInput("Invalid entry. Please enter your first name.")); 
            }
        }

        //Validate email address
        public static string ValidateEmail(string email)
        {
            //first part of email can contain letter and/or numbers. Must contain @ sign. 
            //after @ sign, domain is 5 to 10 characters long.
            //check for .com etc by checking to see if it is 2 to 3 characters long.
            if (Regex.IsMatch(email, @"^[A-z0-9]{5,30}@[A-z]{5,10}.[A-z]{2,3}$"))
            {
                return $"Thank you, you've entered {email}.\n";
            }
            else
            {
                return ValidateEmail(GetUserInput("Invalid entry. Please enter your email."));
            }
        }

        //Validate phone number
        public static string ValidatePhone(string phoneNumber)
        {
            //phone number must match 111-111-1111 format
            if (Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{4}$"))
            {
                return $"Thank you, you've entered {phoneNumber}.\n";
            }
            else
            {
                return ValidatePhone(GetUserInput("Invalid entry. Please enter your phone number."));
            }
        }

        //validate birthday
        public static string ValidateBirthday(string birthday)
        {
            //birthday format must be dd/mm/yyyy
            if (Regex.IsMatch(birthday, @"^\d{2}/\d{2}/\d{4}$"))
            {
                return $"Thank you, you've entered {birthday}.\n";
            }
            else
            {
                return ValidateBirthday(GetUserInput("Invalid entry. Please enter your birthday."));
            }
        }
        
    }
}
            
           
