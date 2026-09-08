public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int[] res = new int[nums.Length];
        int pos = 0;
        int neg = 1;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > 0){
                 res[pos] = nums[i];
                pos += 2;

            }else{
                 res[neg] = nums[i];
                neg += 2;

            }
           
        }

        return res;
    }
}