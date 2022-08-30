// See https://aka.ms/new-console-template for more information

Solution solution = new Solution();
int[] prices = {7,6,4,3,1};
int flex = solution.MaxProfit(prices);
Console.WriteLine(flex);

public class Solution {
    public int MaxProfit(int[] prices)
    {
        int min = int.MaxValue;
        int profit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min) min = prices[i];

            if (prices[i] - min > profit)
                profit = prices[i] - min;

        }

        return profit;
    }
}