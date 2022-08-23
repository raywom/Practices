// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> map = new Dictionary<char, char>();
        Dictionary<char, char> map2 = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++) {
            if (!map.ContainsKey(s[i])) {
                map.Add(s[i], t[i]);
            }
            if (!map2.ContainsKey(t[i])) {
                map2.Add(t[i], s[i]);
            }
            if (map[s[i]] != t[i] || map2[t[i]] != s[i]) {
                return false;
            }
        }
        return true;
    }
}