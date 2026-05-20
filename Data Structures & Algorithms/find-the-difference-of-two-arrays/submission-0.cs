public class Solution {
    public List<List<int>> FindDifference(int[] nums1, int[] nums2) {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        // foreach(int num in nums1) set1.Add(num);
        // foreach(int num in nums2) set2.Add(num);
        // var res1 = new List<int>(set1);
        // res1.RemoveAll(x => set2.Contains(x));
        // var res2 = new List<int>(set2);
        // res2.RemoveAll(x => set1.Contains(x));
        // return new List<List<int>>{res1, res2};
        return new List<List<int>> {
            set1.Except(set2).ToList(),
            set2.Except(set1).ToList()
        };
    }
}