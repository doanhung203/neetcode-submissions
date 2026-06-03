public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>();
        int res = 0;
        foreach (int num in nums) {
            set.Add(num);
        }
        foreach(int num in nums){
            if(!set.Contains(num - 1)){ // check đầu chuỗi, ex [100, 4, 200, 1, 3, 2], check 100 không có 99 trong set -> là đầu chuỗi 
                                        // check 4 skip, không là đầu chuỗi
                                        // check 1 ok tiếp
                int length = 1;
                while(set.Contains(num + length)) length++; //count Consecutive Sequence
                res = Math.Max(res, length);
            }
        }
        return res;
    }
}
