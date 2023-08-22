using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number) => number.ToString().ToList().Sum(num => Math.Pow(double.Parse(num.ToString()), number.ToString().Length)) == number;
}