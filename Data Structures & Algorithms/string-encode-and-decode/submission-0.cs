public class Solution {

    public string Encode(IList<string> strs) {
        string encode = "";
        foreach(string str in strs)
        {
            encode += str.Length.ToString() + '#' + str;
        }

        return encode;
    }

    public List<string> Decode(string s) {
        List<string> decode = new List<string>();
        int i = 0;
        while (i<s.Length)
        {
            int j = i;
            while(s[j]!='#')
                j++;
            int length = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            string content = s.Substring(i, length);
            decode.Add(content);
            i+=length;
        }
        return decode;
   }
}
