public class MyHashMap {
    private const int bucketSize = 10001;
    private int[] arr = new int[bucketSize];
    public MyHashMap() {
        Array.Fill(arr,-1);
    }
    
    public void Put(int key, int value) {
        arr[key%bucketSize] = value;
    }
    
    public int Get(int key) {
        return arr[key%bucketSize];
    }
    
    public void Remove(int key) {
        arr[key%bucketSize] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */