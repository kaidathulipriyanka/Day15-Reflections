using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ReflectonUserRegistration
{
    public class UserRegistration
    {
       
            public bool ValidateFirstName(string firstName)
            {
                 return Regex.IsMatch(firstName, "^[A-Z][a-z]{2,}");
            }
            public bool ValidateLastName(string lastName)
            {
                 return Regex.IsMatch(lastName, "^[A-Z][a-z]{2,}");
            }
            public bool ValidateEmail(string email)
            {
                 return Regex.IsMatch(email, @"^[a-zA-Z0-9]+([.+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.[a-zA-Z]{2,}(?:\.[a-zA-Z]{2,})?$");
            }

            public bool ValidateMobile(string mobile)
            {
                 return Regex.IsMatch(mobile, @"^\d{2}\s\d{10}$");
            }

            public bool ValidatePassword(string password)
            {
                 return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$");
            }

            public bool ClearEmailSamples(string email)
            { 
                return true;
            }

            public bool ValidateAllRules(object user, string methodName, string value)
            {
                 MethodInfo method = typeof(UserRegistration).GetMethod(methodName);
                if (method != null)
                {
                    object result = method.Invoke(user, new object[] { value });
                    return (bool)result;
                }
                return false;
            }

        }
    }
