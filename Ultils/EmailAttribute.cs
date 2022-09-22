using System;
using System.Net.Mail;

namespace DeliveryProtocol.Ultils
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property ,Inherited = true)]
    public class EmailABCAttribubte : Attribute
    {
        public bool isEmailFormat { get; private set; }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                isEmailFormat = true;
            }
            catch (FormatException)
            {
                isEmailFormat = false;
            }
            return isEmailFormat;
        }


    }
}

