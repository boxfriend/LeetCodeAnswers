public class Solution {
    public int RepeatedNTimes(int[] nums) {
        var hash = new HashSet<int>();
        foreach(var num in nums)
            if(!hash.Add(num))
                return num;
        
        return 0;
    }
}
//Runtime: 104 ms, faster than 98.91%
//Memory Usage: 43.2 MB, less than 8.69%