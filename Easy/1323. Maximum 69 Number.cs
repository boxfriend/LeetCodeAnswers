public class Solution {
    public int Maximum69Number (int num) {
        var chars = num.ToString().ToCharArray();
        
        for(var i = 0; i < chars.Length; i++)
        {
            if(chars[i] == '6')
            {
                chars[i] = '9';
                break;
            }
        }
        
        return Int32.Parse(new string(chars));
    }
}
//Runtime: 40 ms, faster than 60.34%
//Memory Usage: 25 MB, less than 100.00%