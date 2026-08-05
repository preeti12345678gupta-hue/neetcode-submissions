public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int count = 0;
        int length = 0;
        int inc = 1;
        int dec = 1;
        int res = 1;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > nums[i - 1]){
                inc++;
                dec = 1;
            }else if(nums[i] < nums[i - 1]){
                dec++;
                inc = 1;
            }else{
                inc = 1;
                dec =1;
            }

            res = Math.Max(res, Math.Max(inc, dec));
        }

        return res;
    }
}