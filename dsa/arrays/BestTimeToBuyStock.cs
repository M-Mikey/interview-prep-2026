// Pattern: Greedy - track min price, compute max profit
// Time: O(n) | Space: O(1)
public class BestTimeToBuyStock {
    public int Solve(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        foreach (int price in prices) {
            if (price < minPrice)
                minPrice = price;
            else if (price - minPrice > maxProfit)
                maxProfit = price - minPrice;
        }
        return maxProfit;
    }
}
