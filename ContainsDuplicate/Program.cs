// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Solution solution = new Solution();
var flex = solution.ContainsDuplicate(new int[] { 1, 2, 2, 3, 1 });
Console.WriteLine(flex);

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] == nums[j])
                {
                    break;
                }
                else if(j==nums.Length-1)
                {
                    return false;
                }
            }
        }

        return false;
    }
}