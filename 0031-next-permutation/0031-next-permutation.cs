public class Solution {
    public void NextPermutation(int[] nums) {
        int n = nums.Length;
        int i = n-2;

        while(i>=0 && nums[i] >= nums[i+1])
        {
            i--;
        }

        if(i>=0)
        {
            int j =n-1;
            while(nums[j] <= nums[i])
            {
                j--;
            }

            int temp = nums[i];
            nums[i] = nums[j];
            nums[j]= temp;
             
             }

            Reverse(nums,i+1,n-1);
    }
    private void Reverse(int[] nums,int start,int end)
    {
        while(start<end)
        {
            int temp = nums[start];
            nums[start]=nums[end];
            nums[end]=temp;
            start++;
            end--;

        }
    }        
        
    }

