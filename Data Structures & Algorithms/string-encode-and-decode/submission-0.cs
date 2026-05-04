public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs){
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while(i < s.Length){
            int j = i;
            //find index of # after length 
            while(s[j] != '#'){
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));
            
            //fing string after #
            string str = s.Substring(j + 1, length);
            result.Add(str);
            
            //pass passed string
            i = j + 1 + length;
        }
        return result;
   }
}
