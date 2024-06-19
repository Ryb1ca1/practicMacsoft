using System.Linq;
using System.Collections.Generic;

public class Kata
{
    private static Dictionary<char, char> encoder = new Dictionary<char, char>
    {
        {'G', 'A'}, {'A', 'G'}, {'g', 'a'}, {'a', 'g'}, {'D', 'E'}, {'E', 'D'}, {'d', 'e'}, {'e', 'd'},
        {'R', 'Y'}, {'Y', 'R'}, {'r', 'y'}, {'y', 'r'}, {'P', 'O'}, {'O', 'P'}, {'p', 'o'}, {'o', 'p'},
        {'L', 'U'}, {'U', 'L'}, {'l', 'u'}, {'u', 'l'}, {'K', 'I'}, {'I', 'K'}, {'k', 'i'}, {'i', 'k'}
    };

    public static string Decode(string s) => Encode(s);
    public static string Encode(string s) => string.Concat(s.Select(c => encoder.ContainsKey(c) ? encoder[c] : c));
}
