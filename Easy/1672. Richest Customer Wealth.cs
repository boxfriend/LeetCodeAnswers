public class Solution {
    public int MaximumWealth(int[][] accounts) {
        var answer = 0;
        foreach(var arr in accounts)
        {
            var wealth = 0;
            for(var i = 0; i < arr.Length; i++)
                wealth += arr[i];
            
            answer = (answer > wealth) ? answer : wealth;
        }
        
        return answer;
    }
}
//Runtime: 136 ms, faster than 29.68%
//Memory Usage: 37.7 MB, less than 48.13%

public class Solution1 {
    public int MaximumWealth(int[][] accounts) => accounts.Max(acc => acc.Sum());
}
//Runtime: 76 ms, faster than 98.85%
//Memory Usage: 39.4 MB, less than 8.36%