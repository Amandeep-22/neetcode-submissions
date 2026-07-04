public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if(nums.Length==0)
            return 0;
            
        HashSet<int> hs = new HashSet<int>();

        for(int i = 0; i<nums.Length; i++)
        {
            hs.Add(nums[i]);
        }

        int ans = 1;

        for(int i=0; i<nums.Length; i++)
        {
            if(!hs.Contains(nums[i]-1))
            {
                int num = nums[i];
                int j = 1;
                while(hs.Contains(num+1))
                {
                    num++;
                    j++;
                }
                ans = Math.Max(ans,j);
            }
        }

        return ans;
    }
}
