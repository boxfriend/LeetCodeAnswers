public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length < 2) return 0;
        
        var profit = 0;
        var biggestGain = prices[prices.Length-1];
        for(var i = prices.Length - 2; i >= 0; i--)
        {
            biggestGain = Math.Max(prices[i], biggestGain);
            profit = Math.Max(profit, biggestGain - prices[i]);
        }
        return profit;
    }
}
//Runtime: 212 ms, faster than 99.84%
//Memory Usage: 48.2 MB, less than 5.47%