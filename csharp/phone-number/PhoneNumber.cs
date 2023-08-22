using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        // only get numbers
        phoneNumber = new Regex(@"[^\d]").Replace(phoneNumber, "");
        var restrictedChars = new[]{'0','1'};

        // check for correct length
        if(phoneNumber.Length > 11 || phoneNumber.Length < 10)
            throw new ArgumentException();

        if (phoneNumber.Length == 11)
        {
            // check for correct country code
            if (phoneNumber[phoneNumber.Length - 11] != '1')
                throw new ArgumentException();

            phoneNumber = phoneNumber.Remove(0,1);
        }

        // check restricted chars (2-9)
        if (restrictedChars.Contains(phoneNumber[0]) || restrictedChars.Contains(phoneNumber[3]))
            throw new ArgumentException();

        return phoneNumber;
    }
}