public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int sum = 0;
        int count = 0;
        for(int i = 0; i < arr.Length; i++){
            sum += arr[i];
            if(i >= k){
                sum -= arr[i - k];
            }
            if(i >= k - 1){
                if(sum >= k * threshold){
                    count++;
                }
            }
        }
        return count;
    }
}