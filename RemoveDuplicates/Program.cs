namespace RemoveDuplicates // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums =
            {
                0, 0, 1, 1, 1, 2, 2, 3, 3, 4
            };

            Console.WriteLine(RemoveDuplicates(nums));
        }

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
}