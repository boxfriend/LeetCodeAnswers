public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        var builder1 = new StringBuilder();
        foreach(var str in word1)
            builder1.Append(str);
        
        var builder2 = new StringBuilder();
        foreach(var str in word2)
            builder2.Append(str);
        
        return builder1.ToString() == builder2.ToString();
    }
}
//Runtime: 200 ms, faster than 5.49%
//Memory Usage: 38.8 MB, less than 63.19%

public class Solution1 {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        var str1 = "";
        foreach(var str in word1)
            str1 += str;
        
        var str2 = "";
        foreach(var str in word2)
            str2 += str;
        
        return str1 == str2;
    }
}
//Runtime: 96 ms, faster than 68.13%
//Memory Usage: 40.8 MB, less than 7.69%

public class Solution2 {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        var str1 = string.Join("", word1);
        var str2 = string.Join("", word2);
        return str1 == str2;
    }
}
//Runtime: 145 ms, faster than 23.63%
//Memory Usage: 38.3 MB, less than 95.05%

public class Solution3 {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        var builder1 = new StringBuilder();
        for(var i = 0; i < word1.Length; i++)
            builder1.Append(word1[i]);
        
        var builder2 = new StringBuilder();
        for(var i = 0; i < word2.Length; i++)
            builder2.Append(word2[i]);
        
        return builder1.ToString() == builder2.ToString();
    }
}
//Runtime: 96 ms, faster than 68.13%
//Memory Usage: 40.2 MB, less than 33.52%