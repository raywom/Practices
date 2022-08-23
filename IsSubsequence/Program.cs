// See https://aka.ms/new-console-template for more information

string s = "";
string t = "";
Solution solution = new Solution();
bool isSubsequence = solution.IsSubsequence(s, t);
Console.WriteLine(isSubsequence);
public class Solution {
    public bool IsSubsequence(string s, string t)
    {
        int count = 0;
        if (s.Length == 0) return true;
        if (t.Length == 0) return false;

        
        foreach (var t1 in t)
        {
            if (s[count] == t1)
            {
                count++;
                if (count == s.Length)
                {
                    return true;
                }
            }
        }

        return false;
    }
}