using System;
using System.Collections.Generic;
using System.Linq;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        if (rows < 0)
            throw new ArgumentException();
        if (rows == 0)
            return new int[0][];

        // define the starting point
        var result = new int[rows][];
        result[0] = new[] { 1 };

        // loop for ever row, can't be parallel because each row depends on the last
        for (var i = 0; i < rows - 1; i++)
        {
            var currentArrayLength = result[i].Length;
            var mirrorIndex = (double)currentArrayLength / 2;

            // each new row is 1 index larger
            result[i + 1] = new int[++currentArrayLength];

            // calculate each value until the middle index is reached
            for (var j = -1; j < (int)mirrorIndex; j++)
                result[i + 1][j + 1] = j > -1 ? result[i][j] + result[i][j + 1] : result[i][j + 1];

            // the calculated values can now be flipped since all values in pascals triangle appear in mirrored pairs
            var input = result[i + 1].Take((int)Math.Ceiling(mirrorIndex)).Reverse().ToArray();
            var destinationIndex = mirrorIndex % 1 != 0 ? (int)Math.Ceiling(mirrorIndex) : (int)Math.Ceiling(mirrorIndex) + 1;
            Array.Copy(input, 0, result[i + 1], destinationIndex, input.Length);
        }

        return result;
    }

}