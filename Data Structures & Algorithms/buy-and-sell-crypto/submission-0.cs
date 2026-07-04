public class Solution {
    public int MaxProfit(int[] prices) {
        
        int MaxProfit = 0;
        int currentMax = prices[0];
        int currentMin = prices[0];
        for(int i = 1; i<prices.Length; i++)
        {
            if(currentMax<prices[i])
            {
                currentMax = prices[i];
            }
            if(currentMin>prices[i])
            {
                currentMin = prices[i];
                currentMax = prices[i];
            }
            MaxProfit = Math.Max(MaxProfit, currentMax - currentMin);
        }

        return MaxProfit;
    }
}
