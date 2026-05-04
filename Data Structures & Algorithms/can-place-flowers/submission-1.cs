public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int[] f = new int[flowerbed.Length + 2];
        for(int i = 0; i < flowerbed.Length; i++){
            f[i + 1] = flowerbed[i];
        }
        for(int i = 1; i < f.Length - 1; i++){
            if(f[i - 1] == 0 && f[i] == 0 && f[i + 1] == 0){
                f[i] = 1;
                n--;
            }
        }
        return n <= 0;
    }
}