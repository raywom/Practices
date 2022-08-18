// See https://aka.ms/new-console-template for more information

Solution solution = new Solution();
int[] nums = new int[] {1, 2, 3, 4};
var flex = solution.RunningSum(nums);

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