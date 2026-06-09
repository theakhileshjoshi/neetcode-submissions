public class Solution {
    public int MajorityElement(int[] nums) {
        return nums.GroupBy(i => i).Where(i => i.Count() > nums.Length/2).Select(i => i.Key).First();
    }
}