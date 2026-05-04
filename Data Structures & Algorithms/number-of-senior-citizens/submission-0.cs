public class Solution {
    public int CountSeniors(string[] details) {
        int rs = 0;
        foreach(string d in details){
            if(int.Parse(d.Substring(11,2)) > 60) rs++;
        }
        return rs;
    }
}