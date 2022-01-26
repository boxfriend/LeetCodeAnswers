public class Solution {
    private Dictionary<char, int> dict = new Dictionary<char, int> {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    public int RomanToInt(string s) {
        var total = 0;
        for(int i = s.Length-1; i >= 0; i--)
        {
            var toAdd = (i < s.Length-1 && dict[s[i]] < dict[s[i+1]]) ? -dict[s[i]] : dict[s[i]];
            total += toAdd;
        }
            
        return total;
    }
}
//Runtime: 118 ms, faster than 34.66%
//Memory Usage: 36 MB, less than 54.21%