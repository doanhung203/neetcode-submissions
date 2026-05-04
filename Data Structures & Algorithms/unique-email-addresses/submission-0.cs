public class Solution {
    public int NumUniqueEmails(string[] emails) {
        var unique = new HashSet<string>();

        foreach(string e in emails){
            string[] parts = e.Split('@');
            string local = parts[0];
            string domain = parts[1];

            local = local.Split('+')[0];
            local = local.Replace(".","");
            unique.Add(local + "@" + domain);
        }
        return unique.Count;
    }
}