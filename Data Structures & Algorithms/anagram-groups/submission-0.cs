public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> groups = new();

        foreach(string str in strs){
            char[] ch = str.ToCharArray();
            Array.Sort(ch);
            string sortedStr = new string(ch);
            if(!groups.ContainsKey(sortedStr)){
                groups[sortedStr] = new List<string>();
                
            }
            groups[sortedStr].Add(str);
        }

        return groups.Values.ToList();
    }
}
