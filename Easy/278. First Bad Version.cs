/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        return BinarySearch(0,n);
    }
    
    private int BinarySearch(int l, int r)
    {
        var index = l + (r-l)/2;
        if(IsBadVersion(index))
            return BinarySearch(l, index-1);
        if(IsBadVersion(index+1))
            return index+1;
        
        return BinarySearch(index+1,r);
    }
}
//Runtime: 34 ms, faster than 60.80%
//Memory Usage: 25.2 MB, less than 82.12%