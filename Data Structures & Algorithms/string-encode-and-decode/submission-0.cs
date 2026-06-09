public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encodedString = new StringBuilder();
        foreach(string str in strs){     
            encodedString.Append(str.Length.ToString("D3"));
            encodedString.Append("#");
            encodedString.Append(str);
        }
        return encodedString.ToString();
    }

    public List<string> Decode(string s) {
        List<String> result = new();
        int i = 0;

        while (i < s.Length) {
            int len = int.Parse(s.Substring(i, 3));
            i += 4; // skip "005#"
            result.Add(s.Substring(i, len));
            i += len;
        }
        return result;
    }

}
