public class Solution {
    public int SubtractProductAndSum(int n) {
        (var product, var sum) = ProcessDigits(n,1,0);
        return product - sum;
    }
    
    private (int product,int sum) ProcessDigits(int n, int product, int sum)
    {
        if(n < 1)
            return (product, sum);
        var digit = n%10;
        return ProcessDigits(n/10,product*digit,sum+digit);
    }
}
//Runtime: 36 ms, faster than 35.70%
//Memory Usage: 25.3 MB, less than 41.13%