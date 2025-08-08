public class Solution {
    public int Search(int[] nums, int target) {
        
      int left = 0, right = nums.Length - 1;

        while  (left<=right){
        
          int mid = left + (right - left) / 2;
        
        if(nums[mid] == target)
        return mid;
   
     // Left half is sorted
            if (nums[left] <= nums[mid]) {
                if (target >= nums[left] && target < nums[mid]) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
     //left half is sorted
           else {
                if (target > nums[mid] && target <= nums[right]) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
    }
          return -1;
    }
   
}