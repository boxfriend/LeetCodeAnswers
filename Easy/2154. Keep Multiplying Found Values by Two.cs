public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        var num = original;
        while(Array.Exists(nums, x => x == num))
            num *= 2;
        
        return num;
    }
}
//Runtime: 153 ms, faster than 37.45%
//Memory Usage: 38.1 MB, less than 92.88%

public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        var hash = new HashSet<int>();
        for(var i = 0; i < nums.Length; i++)
            hash.Add(nums[i]);
        
        var num = original;
        while(hash.Contains(num))
            num *= 2;
        
        return num;
    }
}
//Runtime: 84 ms, faster than 89.51%
//Memory Usage: 40.9 MB, less than 5.99%