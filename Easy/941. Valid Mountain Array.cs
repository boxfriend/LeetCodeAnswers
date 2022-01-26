public class Solution {
    public bool ValidMountainArray(int[] arr) {
        var isIncreasing = false;
        var isDecreasing = false;
        for(var i = 1; i < arr.Length; i++)
        {
            var diff = arr[i] - arr[i-1];
            if(diff == 0) return false;
            if(diff > 0)
            {
                if(isDecreasing) return false;
                
                isIncreasing = true;
            }
            
            if(diff < 0)
                isDecreasing = true;
        }
        return isIncreasing && isDecreasing;
    }
}
//Runtime: 257 ms, faster than 5.70%
//Memory Usage: 40.9 MB, less than 92.69%