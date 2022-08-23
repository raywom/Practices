// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int[] nums = {1,7,3,6,5,6};
Solution solution = new Solution();
int flex = solution.PivotIndex(nums);
Console.WriteLine(flex);

public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }
        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (leftSum == sum - leftSum - nums[i]) {
                return i;
            }
            leftSum += nums[i];
        }
        return -1;
    }
}