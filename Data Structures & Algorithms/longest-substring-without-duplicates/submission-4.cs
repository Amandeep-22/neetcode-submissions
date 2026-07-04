public class Solution {
    public int LengthOfLongestSubstring(string s) {

        int n = s.Length;
        if(n==0)
            return 0;
        
        int[] freq = new int[128];

        int i = 0;
        int j = 1;
        int ans = 1;
        int idx = s[0];
        freq[idx]++;
        
        while(j<n)
        {
            int end = s[j];
            ans = Math.Max(ans, j-i);
            freq[end]++;
            while(freq[end]>1)
            {
                int start = s[i];
                freq[start]--;
                i++;
            }
            j++;
        }
        ans = Math.Max(ans, j-i);
        return ans;
    }
}
