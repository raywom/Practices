namespace Array;

public class RemoveDuplicate
{
    public static int RemoveDuplicates(int[] nums) {
        var size = nums.Length;
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (nums[i] == nums[j])
                {
                    for(int k = j; k < size - 1; k++)
                    {
                        nums[k] = nums[k + 1];
                    }

                    j--;
                    size--;
                }
            }
        }

        var arr = nums[0..size];
        return arr.Length+1;
    }
}