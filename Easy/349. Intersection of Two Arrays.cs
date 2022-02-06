public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var hash1 = new HashSet<int>();
        foreach(var num in nums1)
            hash1.Add(num);
        
        var hash2 = new HashSet<int>();
        foreach(var num in nums2)
        {
            if(hash1.Contains(num))
                hash2.Add(num);
        }
        
        var nums = new int[hash2.Count];
        hash2.CopyTo(nums);
        return nums;
            
    }
}
//Runtime: 132 ms, faster than 72.21%
//Memory Usage: 43.2 MB, less than 5.09%