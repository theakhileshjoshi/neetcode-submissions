public class MyHashSet {
    private bool[] nums;
    public MyHashSet() {
        nums = new bool[1000000];
    }
    
    public void Add(int key) {
        nums[key] = true;
    }
    
    public void Remove(int key) {
        nums[key] = false;
    }
    
    public bool Contains(int key) {
        return nums[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */