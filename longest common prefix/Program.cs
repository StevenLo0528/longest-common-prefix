// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        string[] strs = { "flower", "flow", "flight" };
        Console.WriteLine("Longest Common Prefix: " + LongestCommonPrefix(strs));
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return string.Empty;
        }

        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrEmpty(prefix))
                {
                    return string.Empty;
                }
            }
        }
        return prefix;
    }
}