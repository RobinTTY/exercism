using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var result = (IsNewYork: false, IsFake: false, LocalNumber: string.Empty);
        result.IsNewYork = phoneNumber.Substring(0, 3) == "212";
        result.IsFake = phoneNumber.Substring(4, 3) == "555";
        result.LocalNumber = phoneNumber[^4..];
        return result;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
