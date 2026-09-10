public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int left = 0;
        int right = arr.Length - k;
        while(left < right){
            int mid = left + (right - left) / 2;
            int leftdis = x - arr[mid];
            int rightdis = arr[mid + k] - x;

            if(leftdis > rightdis){
                left = mid + 1;
            }else{
                right = mid;
            }

        }
        List<int> res = new List<int>();
        for(int i = left; i < left + k; i++){
            res.Add(arr[i]);
        }
        return res;
    }
}