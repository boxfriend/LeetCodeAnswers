public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        
        var dictS = StringToDict(s);
        var dictT = StringToDict(t);
        
        foreach(var pair in dictS)
        {
            if(!dictT.ContainsKey(pair.Key)) return false;
            if(pair.Value != dictT[pair.Key]) return false;
        }
        
        return true;
    }
    
    private Dictionary<char,int> StringToDict(string s)
    {
        var dict = new Dictionary<char,int>();
        for(var i =0; i < s.Length; i++)
        {
            if(dict.ContainsKey(s[i]))
                dict[s[i]]++;
            else
                dict.Add(s[i],0);
        }
        return dict;
    }
    
}
//Runtime: 76 ms, faster than 94.41%
//Memory Usage: 39.3 MB, less than 54.49%