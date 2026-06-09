public class MyHashSet {
    private int[] nums = Enumerable.Repeat(-1, 1000000).ToArray();
    public MyHashSet() {
        
    }
    
    public void Add(int key) {
        nums[key] = key;
    }
    
    public void Remove(int key) {
        nums[key] = -1;
    }
    
    public bool Contains(int key) {
        if(nums[key] == key)
            return true;
        else
            return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */