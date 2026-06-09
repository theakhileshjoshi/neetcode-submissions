public class Solution {
    public bool hasDuplicate(int[] nums) {
       HashSet<int> seenNums = new HashSet<int>();
       foreach(int num in nums){
        if(!seenNums.Add(num))
            return true;
       }
       return false;
    }
}