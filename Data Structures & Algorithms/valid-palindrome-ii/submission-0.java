class Solution {
    public boolean validPalindrome(String s) {
        char[] arr = s.toCharArray();
        int l = 0, r = arr.length - 1;
        int count = 1;
        while(l < r){
            if(arr[l] == (arr[r])){
                l++;
                r--;
            } else{
                if(arr[l + 1] == (arr[r]) || arr[l] == (arr[r - 1])){ 
                    l++;
                    r--;
                    count--; 
                }else return false;
                if(count < 0) return false;
            }
        }
        return true;
    }
}