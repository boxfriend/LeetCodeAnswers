public class Solution {
    public int GetLucky(string s, int k) {
        var sum = 0;
        var charNum = (int)'a' - 1;
        foreach(var ch in s)
            sum += AddDigits(((int)ch - charNum));
        
        while(k > 1)
        {
            sum = AddDigits(sum);
            k--;
        }
        return sum;
    }
    
    private int AddDigits(int num)
    {
        var sum = 0;
        while(num > 0)
        {
            sum += num % 10;
            num = num/10;
        }
        
        return sum;
    }
}
//Runtime: 116 ms, faster than 27.59%
//Memory Usage: 35.2 MB, less than 56.90%