using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {
        /*Constant variable declaration*/
        private const string ErrorMsgUser= "Username must be provided";

        private const string ErrorMsgEmail = "Username must be provided";

        private const string ErrorMsgPassword = "Username must be provided";


        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return ErrorMsgUser;
            if (string.IsNullOrWhiteSpace(email))
                return ErrorMsgEmail;
            if (string.IsNullOrWhiteSpace(password))
                return ErrorMsgPassword;
            

            return string.Empty;
        }
        
    }
}
