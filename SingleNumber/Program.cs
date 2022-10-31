// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Solution solution = new Solution();
var flex = solution.SingleNumber(new int[] { 1, 2, 2, 3, 1 });
Console.WriteLine(flex);

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        var result = 0;
        foreach (var num in nums)
        {
            result ^= num;
        }

        return result;
    }
}