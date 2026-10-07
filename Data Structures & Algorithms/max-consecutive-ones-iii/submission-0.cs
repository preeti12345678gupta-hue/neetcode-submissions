public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int max = 0;
        int left = 0;
        int zero = 0;
        for(int right = 0; right < nums.Length; right++){
            if(nums[right] == 0){
                zero++;

            }

            while(zero > k){
                if(nums[left] == 0){
                    zero--;
                }
                left++;
            }
            if(zero <= k){
                max = Math.Max(max, right - left + 1);
            }
        }
        return max;
    }
}