using System.Linq;

public static class RnaTranscription
{
    // G -> C, C -> G, T -> A, A -> U
    public static string ToRna(string nucleotide) =>
        new string(nucleotide
            .Select(c => c == 'G' ? 'C' : c == 'C' ? 'G' : c == 'T' ? 'A' : c == 'A' ? 'U' : c).ToArray());
}