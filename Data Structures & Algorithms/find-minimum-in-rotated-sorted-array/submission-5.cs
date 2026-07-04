public class Solution {
    public int FindMin(int[] nums) {
        
        int l = 0;
        int r = nums.Length - 1;
        int n = nums.Length - 1;
        int ans = 0;

        if(n==0)
        {
            return nums[0];
        }
        else if(n==1)
        {
            if(nums[0]<nums[1])
                return nums[0];
            else
                return nums[1];
        }
        else if(nums[0]<nums[n])
            return nums[0];

        while(l<=r)
        {
            int mid = l + (r-l)/2;

            if((mid==0 && nums[mid+1]>nums[mid]) 
                || (mid==n && nums[mid-1]>nums[mid]) || (nums[mid+1]>nums[mid] && nums[mid-1]>nums[mid]) )
                {
                    ans = nums[mid];
                    break;
                }
            else if(nums[mid]>nums[n])
            {
                l=mid+1;
            }
            else if(nums[mid]<nums[0])
            {
                r=mid-1;
            }
        }

        return ans;

    }
}
