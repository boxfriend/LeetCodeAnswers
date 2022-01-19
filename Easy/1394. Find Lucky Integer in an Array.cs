public class Solution {
    public int FindLucky(int[] arr) {
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < arr.Length; i++)
        {
            if(dict.ContainsKey(arr[i]))
                dict[arr[i]]++;
            else
                dict.Add(arr[i], 1);
        }
        
        var list = new List<int>();
        foreach(var pair in dict)
        {
            if(pair.Key == pair.Value)
                list.Add(pair.Key);
        }
        
        var biggest = -1;
        
        foreach(var key in list)
            biggest = (biggest > key) ? biggest : key;
        
        return biggest;
    }
}
//Runtime: 180 ms, faster than 11.11%
//Memory Usage: 36.7 MB, less than 74.07%