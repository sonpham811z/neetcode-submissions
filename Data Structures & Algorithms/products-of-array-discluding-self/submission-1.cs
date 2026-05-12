public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];

        int pre = 1;
        for(int i = 0; i < nums.Length; i++)
        {
            res[i] = pre;
            pre *= nums[i];
        }

        int back = 1;
        for(int i = nums.Length-1; i > -1; i--)
        {
            res[i]*=back;
            back*=nums[i];
        }

        return res;
    }
}
