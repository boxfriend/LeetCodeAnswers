public class Solution {
    public int HammingWeight(uint n) {
        var count = 0;
        while(n > 0)
        {
            if(n%2 > 0)
                count++;
            
            n /= 2;
        }
        
        return count;
    }
}
//Runtime: 30 ms, faster than 57.23%
//Memory Usage: 22.4 MB, less than 71.23%