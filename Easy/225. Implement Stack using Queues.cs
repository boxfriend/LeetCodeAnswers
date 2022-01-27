public class MyStack {
    
    private Queue<int> entryQueue = new Queue<int>();
    private Queue<int> endQueue = new Queue<int>();
    
    public int Count => entryQueue.Count + endQueue.Count;

    public MyStack() {
        
    }
    
    public void Push(int item) {
        var queue = entryQueue.Count > 0 ? entryQueue : endQueue;
        queue.Enqueue(item);
    }
    
    public int Pop() {
        return GetLastItemInQueue(true);
    }
    
    public int Top() {
        return GetLastItemInQueue();
    }
    
    public bool Empty() => Count == 0;
    
    private int GetLastItemInQueue (bool dequeue = false)
    {
        var queue = entryQueue.Count > 0 ? entryQueue : endQueue;
        var finalQueue = queue == entryQueue ? endQueue : entryQueue;

        while(queue.Count > 1)
            finalQueue.Enqueue(queue.Dequeue());

        var item = queue.Dequeue();

        if(!dequeue)
            finalQueue.Enqueue(item);

        return item;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
 
 //Runtime: 191 ms, faster than 16.41%
 //Memory Usage: 38.4 MB, less than 68.36%