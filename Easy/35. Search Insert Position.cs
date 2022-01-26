public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return BinarySearch(nums, target, 0, nums.Length-1);
    }
    
    private int BinarySearch(int[] nums, int target, int l, int r)
    {
        r = Math.Max(r, 0);
        l = Math.Min(l, nums.Length-1);
        
        if(r <= l) 
            return l;
        
        var index = l + (r-l)/2;
        if(nums[index] == target) return index;
        
        if(target > nums[index])
            return BinarySearch(nums, target, index+1,r);
        
        return BinarySearch(nums, target, l, index-1);
    }
}
//Runtime: 145 ms, faster than 19.89%
//Memory Usage: 36.6 MB, less than 75.45%

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var min = 0;
        var max = nums.Length-1;
        
        while(min <= max)
        {
            var i = min + (max-min)/2;
            
            if(target == nums[i]) return i;
            
            if(target < nums[i])
                max = i-1;
            else
                min = i+1;
        }
        return min;
    }
}
//Runtime: 129 ms, faster than 32.06%
//Memory Usage: 36.4 MB, less than 85.26%

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return BinarySearch(nums, target, 0, nums.Length-1);
    }
    
    private int BinarySearch(int[] nums, int target, int l, int r)
    {
        if(r < l) 
            return l;
        
        var index = l + (r-l)/2;
        if(nums[index] == target) return index;
        
        if(target > nums[index])
            return BinarySearch(nums, target, index+1,r);
        
        return BinarySearch(nums, target, l, index-1);
    }
}
//Runtime: 84 ms, faster than 86.98%
//Memory Usage: 38.4 MB, less than 36.90%