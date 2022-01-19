public class MyCircularDeque {

    private int[] queue;
    private int frontOfQueue, backOfQueue;
    private int Count { get; set; }
    private readonly int max;
    
    public MyCircularDeque(int k) {
        queue = new int[k];
        
        max = k;
    }
    
    public bool InsertFront(int value) {
        if(IsFull()) return false;
        
        frontOfQueue = DecrementPointer(frontOfQueue);
        queue[frontOfQueue] = value;
        Count++;
        return true;
    }
    
    private int DecrementPointer(int pointer)
    {
        return pointer == 0 ? max - 1 : pointer - 1;
    }
    
    private int IncrementPointer(int pointer)
    {
        return pointer == max-1 ? 0 : pointer + 1;
    }
    
    public bool InsertLast(int value) {
        if(IsFull()) return false;
        
        queue[backOfQueue] = value;
        backOfQueue = IncrementPointer(backOfQueue);
        Count++;
        
        return true;
    }
    
    public bool DeleteFront() {
        if(IsEmpty()) return false;
        frontOfQueue = IncrementPointer(frontOfQueue);
        Count--;
        return true;
    }
    
    public bool DeleteLast() {
        if(IsEmpty()) return false;
        backOfQueue = DecrementPointer(backOfQueue);
        Count--;
        return true;
    }
    
    public int GetFront() {
        if(IsEmpty()) return -1;
        
        return queue[frontOfQueue];
    }
    
    public int GetRear() {
        if(IsEmpty()) return -1;
        
        return queue[DecrementPointer(backOfQueue)];
    }
    
    public bool IsEmpty() {
        return Count == 0;
    }
    
    public bool IsFull() {
        return Count == max;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */
 
 //Runtime: 187 ms, faster than 25.81%
 //Memory Usage: 43.8 MB, less than 80.65%