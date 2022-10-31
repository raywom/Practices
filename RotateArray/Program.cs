// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var solution = new Solution();
solution.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
Console.WriteLine("hello");

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        if (nums.Length == 0 || k == 0)
        {
            return;
        }

        k = k % nums.Length;

        int[] temp = new int[k];
        for (int i = 0; i < k; i++)
        {
            temp[i] = nums[nums.Length - k + i];
        }

        for (int i = nums.Length - k - 1; i >= 0; i--)
        {
            nums[i + k] = nums[i];
        }

        for (int i = 0; i < k; i++)
        {
            nums[i] = temp[i];
        }
    }
}