public class MinStack {

    public int Count { get; private set; }
    private Node top;
    
    public MinStack() {
        top = new Node(0,null);
    }
    
    public void Push(int val) {
        var newTop = new Node(val, top);
        top = newTop;
        Count++;
    }
    
    public void Pop() {
        if (top == null) return;
			
        var item = top.value;
        top = top.next;
        Count--;
    }
    
    public int Top() {
        return top.value;
    }
    
    public int GetMin() {
        var min = top.value;
        var node = top;
        while(node.next != null)
        {
            min = (node.value < min) ? node.value : min;
            node = node.next;
        }
        return min;
    }
    
    private class Node
    {
        public readonly int value;
        public readonly Node next;

        public Node (int value, Node next)
        { 
            this.next = next;
            this.value = value;
        }
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
 
 //Runtime: 503 ms, faster than 10.09%
 //Memory Usage: 46.4 MB, less than 58.31%