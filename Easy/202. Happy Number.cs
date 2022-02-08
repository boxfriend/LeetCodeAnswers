public class Solution {
    private HashSet<int> hash = new HashSet<int>();
    public bool IsHappy(int n) {
        var sum = 0;
        while(n > 0)
        {
            var x = n % 10;
            sum += x * x;
            n = n / 10;
        }
        
        if(sum == 1)
            return true;
        
        return hash.Add(sum) ? IsHappy(sum) : false;
    }
}
//Runtime: 59 ms, faster than 41.05%
//Memory Usage: 27.8 MB, less than 59.68%