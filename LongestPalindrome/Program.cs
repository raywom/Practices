// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class Solution {
    public int LongestPalindrome(string s) {
        var dict = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }
        var result = 0;
        var hasOdd = false;
        foreach (var item in dict)
        {
            if (item.Value % 2 == 0)
            {
                result += item.Value;
            }
            else
            {
                hasOdd = true;
                result += item.Value - 1;
            }
        }
        return hasOdd ? result + 1 : result;
    }
}