public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hash = new HashSet<int>();
        foreach(var i in nums)
        {
            if(hash.Contains(i))
                return true;
            
            hash.Add(i);
        }
        return false;
    }
}
//Runtime: 263 ms, faster than 39.61%
//Memory Usage: 46.1 MB, less than 57.15%