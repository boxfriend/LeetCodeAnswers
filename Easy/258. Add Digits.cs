public class Solution {
    public int AddDigits(int num) {
        var sum = 0;
        while(num > 0)
        {
            sum += num % 10;
            num = num/10;
        }
        
        return sum >= 10 ? AddDigits(sum) : sum;
    }
}
//Runtime: 43 ms, faster than 35.24%
//Memory Usage: 25.3 MB, less than 79.52%