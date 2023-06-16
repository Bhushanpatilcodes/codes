
class Solution {
    public TreeNode sortedArrayToBST(int[] nums) {
        if(nums.length == 0 )
            return null;
            return createTree (nums, 0 , nums.length - 1);                
    }
    public TreeNode createTree(int[] nums, int start, int end){
        if(start > end )
        return null;
        int mid = (start + end )/2;
        TreeNode node = new TreeNode (nums[mid]);
        node.left = createTree(nums,start,mid-1);
        node.right = createTree(nums, mid+1,end);
        return node;
    }
}