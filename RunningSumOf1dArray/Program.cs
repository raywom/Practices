Console.WriteLine("Hello, World!");

public class Solution {
    public int[] RunningSum(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            if (i != 0)
            {
                nums[i] = nums[i - 1] + nums[i];
            }
        }
        return nums;
    }
}