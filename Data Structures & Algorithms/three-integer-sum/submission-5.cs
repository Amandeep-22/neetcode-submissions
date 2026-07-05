public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        List<List<int>> ans = new List<List<int>>();
        int x = 0;
        Array.Sort(nums);
        int i = 0;
        while(i<nums.Length)
        {
            int j = i+1;
            int k = nums.Length-1;
            while(j<k)
            {
                if(j-1>i && nums[j]==nums[j-1])
                {
                    j++;
                }
                else if(nums[i]+nums[j]+nums[k]==0)
                {
                    ans.Add(new List<int>());
                    ans[x].Add(nums[i]);
                    ans[x].Add(nums[j]);
                    ans[x].Add(nums[k]);
                    x++;
                    j++;
                }
                else if(nums[i]+nums[j]+nums[k]<0)
                {
                    j++;
                }
                else
                {
                    k--;
                }
            }
            while(i+1<nums.Length && nums[i]==nums[i+1])
            {
                i++;
            }   
            i++; 
        }

        return ans;
    }
}
