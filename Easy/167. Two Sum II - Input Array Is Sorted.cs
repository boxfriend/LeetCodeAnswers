public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var dict = new Dictionary<int,int>();
        var arr = new int[2];
        for(var i = 0; i < numbers.Length; i++)
        {
            var toCheck = target - numbers[i];
            if(dict.ContainsKey(toCheck))
            {    
                arr = new int[2] { dict[toCheck], i+1 };
                break;
            }
            
            if(!dict.ContainsKey(numbers[i]))
                dict.Add(numbers[i],i+1);
        }
        return arr;
    }
}
//Runtime: 152 ms, faster than 56.06%
//Memory Usage: 39.8 MB, less than 85.57%