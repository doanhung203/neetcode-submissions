public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var stack = new Stack<int>();
        var map = new Dictionary<int, int>();

        for(int i = nums2.Length - 1; i >= 0; i--){
            while(stack.Count > 0 && stack.Peek() <= nums2[i]){
                stack.Pop();
            }

            map[nums2[i]] = stack.Count == 0 ? -1 : stack.Peek();
            stack.Push(nums2[i]);
        }

        var result = new int[nums1.Length];
        for(int i = 0; i < nums1.Length; i++){
            result[i] = map[nums1[i]];
        }

        return result;
    }
}