public class MyQueue {
    
    private Stack<int> stack, dstack;

    public MyQueue() {
        stack = new Stack<int>();
        dstack = new Stack<int>();
    }
    
    public void Push(int x) {
        stack.Push(x);
    }
    
    public int Pop() {       
        MoveToDequeuStack();
        return dstack.Pop();
    }
    
    public int Peek() {
        MoveToDequeuStack();
        return dstack.Peek();
    }
    
    public bool Empty() => (stack.Count + dstack.Count) == 0;
    
    private void MoveToDequeuStack ()
    {
        if (dstack.Count != 0) return;

        while(stack.Count > 0) dstack.Push(stack.Pop());
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
 //Runtime: 221 ms, faster than 5.14%
 //Memory Usage: 38.1 MB, less than 96.15%