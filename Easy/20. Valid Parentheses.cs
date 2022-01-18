public class Solution {
    
    private List<char> rBrackets = new List<char>(){ ')', ']', '>', '}' };
    private List<char> lBrackets = new List<char>(){ '(', '[', '<', '{' };
    
    public bool IsValid(string s) {
        if (string.IsNullOrWhiteSpace(s)) return false;
			
        var stack = new Stack<char>();
        foreach (var ch in s)
        {
            if(IsLeftBracket(ch))
                stack.Push(ch);
            else if (IsRightBracket(ch))
            {
                if (stack.Count == 0 || !BracketsMatch(stack.Pop(), ch)) 
                    return false;
            }
        }
        return stack.Count <= 0;
    }
    
    private bool IsLeftBracket (char ch) => lBrackets.Contains(ch);

    private bool IsRightBracket (char ch) => rBrackets.Contains(ch);

    private bool BracketsMatch(char left, char right) => lBrackets.IndexOf(left) == rBrackets.IndexOf(right);
}
//Runtime: 128 ms, faster than 22.05%
//Memory Usage: 36.2 MB, less than 73.93%