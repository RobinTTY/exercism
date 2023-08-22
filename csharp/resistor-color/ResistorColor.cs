using System;

public static class ResistorColor
{
    public enum ResistorColors
    {
        black,
        brown,
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        grey,
        white
    }

    // will throw an exception if non existing color is used
    public static int ColorCode(string color) => (int)Enum.Parse(typeof(ResistorColors), color.ToLower());

    public static string[] Colors() => Enum.GetNames(typeof(ResistorColors));
}