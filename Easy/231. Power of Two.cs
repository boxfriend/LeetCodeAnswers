public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n == 1 || n == 2) return true;
        if(n == 0 || n % 2 != 0) return false;
        
        return IsPowerOfTwo(n/2);
    }
    
}
//Runtime: 66 ms, faster than 10.13%
//Memory Usage: 27.1 MB, less than 90.94%