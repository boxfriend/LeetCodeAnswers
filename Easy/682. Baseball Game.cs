public class Solution {
    public int CalPoints(string[] ops) {
        var list = new List<int>();
        foreach(var s in ops)
        {
            if(s == "C")
            {
                list.RemoveAt(list.Count-1);
            } else if(s == "D")
            {
                list.Add(list[^1]*2);
            } else if (s == "+")
            {
                var a = list[^1];
                var b = list[^2];
                list.Add(a+b);
            } else
            {
                list.Add(Convert.ToInt32(s));
            }
        }
        var total = 0;
        foreach(var i in list)
            total += i;
        
        return total;
    }
}
//Runtime: 76 ms, faster than 96.19%
//Memory Usage: 39.5 MB, less than 10.48%

public class Solution1 {
    public int CalPoints(string[] ops) {
        var stack = new Stack<int>(); //Testing speed/mem using Stack<T> instead of List<T>
        foreach(var s in ops)
        {
            if(s == "C")
            {
                stack.Pop();
            } else if(s == "D")
            {
                stack.Push(stack.Peek()*2);
            } else if (s == "+")
            {
                var a = stack.Pop();
                var b = stack.Peek();
                stack.Push(a);
                stack.Push(a+b);
            } else
            {
                stack.Push(Convert.ToInt32(s));
            }
        }
        var total = 0;
        while(stack.Count > 0)
            total += stack.Pop();
        
        return total;
    }
}
//Runtime: 115 ms, faster than 52.38%
//Memory Usage: 38 MB, less than 76.19%