public class Solution {
    public bool CheckIfExist(int[] arr) {
        var hash = new HashSet<int>();
        foreach(var i in arr)
        {
            if(hash.Contains(i*2) || (i%2 == 0 && hash.Contains(i/2)))
                return true;
            
            if(hash.Contains(i))
                continue;
            hash.Add(i);
        }
        return false;
    }
}
//Runtime: 143 ms, faster than 27.04%
//Memory Usage: 38.1 MB, less than 85.84%