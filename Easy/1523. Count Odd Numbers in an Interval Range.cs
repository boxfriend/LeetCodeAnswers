public class Solution {
    public int CountOdds(int low, int high) {
        var count = high - low + 1;
        if(count % 2 == 0)
            return count/2;
        
        return (high % 2 == 0) ? count/2 : count/2 + 1;
    }
}
//Runtime: 43 ms, faster than 45.02%
//Memory Usage: 25.3 MB, less than 63.35%