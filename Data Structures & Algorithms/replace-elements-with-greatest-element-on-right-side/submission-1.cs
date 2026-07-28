public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxright = -1;
        for(int i = arr.Length - 1; i >= 0; i--){
            int curr = arr[i];
            arr[i] = maxright;

            maxright = Math.Max(maxright,curr);

        }

        return arr;
    }
}