public class Solution {
    public IList<string> FizzBuzz(int n) {
        var str = new String[n];
        for(int i = 1; i <= n; i++)
        {
            var builder = new StringBuilder();
            
            if(i % 3 == 0)
                builder.Append("Fizz");
            if(i % 5 == 0)
                builder.Append("Buzz");
            else if(i % 3 != 0)
                builder.Append(i.ToString());
            
            str[i-1] = builder.ToString();
        }
        return str;
    }
}
//Runtime: 132 ms, faster than 67.12%
//Memory Usage: 47.1 MB, less than 6.90%