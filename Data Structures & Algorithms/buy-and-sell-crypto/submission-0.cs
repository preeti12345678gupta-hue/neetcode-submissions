public class Solution {
    public int MaxProfit(int[] prices) {
        int minprice = int.MaxValue;
        int maxprofit = 0;
        for(int p = 0; p < prices.Length; p++){
            if(prices[p] < minprice){
                minprice = prices[p];
            }
            if(prices[p] - minprice > maxprofit){
                maxprofit = prices[p] - minprice;
            }
        }
        return maxprofit;
    }
}
