public class Solution {
    private readonly Dictionary<string, int> dict = new Dictionary<string, int>(){
        {"--X",-1},{"X--",-1},
        {"++X",1},{"X++",1}
    };
    public int FinalValueAfterOperations(string[] operations) {
        var x = 0;
        foreach(var s in operations)
            x += dict[s];
        
        return x;
    }
}
//Runtime: 116 ms, faster than 41.01%
//Memory Usage: 38.8 MB, less than 49.76%

public class Solution1 {
    
    public int FinalValueAfterOperations(string[] operations) {
        var x = 0;
        foreach(var s in operations)
            x += s[1] == '+' ? 1 : -1;
        
        return x;
    }
}
//Runtime: 76 ms, faster than 99.03%
//Memory Usage: 40.2 MB, less than 7.13%