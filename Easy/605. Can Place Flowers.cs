public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if(n == 0) return true;
        if(flowerbed == null || n > flowerbed.Length) return false;
        
        var placeable = 0;
        for(var i = 0; i < flowerbed.Length; i++)
        {
            if(flowerbed[i] == 1)
            {
                i++;
                continue;
            }
            
            var prev = (i > 0) ? i-1 : 0;
            var next = (i < flowerbed.Length-1) ? i+1:flowerbed.Length-1;
            
            if(flowerbed[prev] == 0 && flowerbed[i] == 0 && flowerbed[next] == 0)
            {
                flowerbed[i] = 1;
                placeable++;
            }
            
            if(placeable >= n) return true;
        }
        
        return false;
    }
}
//Runtime: 104 ms, faster than 99.24%
//Memory Usage: 42.6 MB, less than 51.71%