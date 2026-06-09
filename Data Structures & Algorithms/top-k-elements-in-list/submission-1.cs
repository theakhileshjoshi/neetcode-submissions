public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new();
        foreach(int num in nums){
            if(!freq.ContainsKey(num)){
                freq[num] = 1;
            }else{
                freq[num]++;
            }
        }

        return freq.OrderByDescending(x => x.Value).Select(x=>x.Key).Take(k).ToArray();
    }
}
