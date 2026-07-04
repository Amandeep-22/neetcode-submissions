public class Solution {
    public bool IsAnagram(string s, string t) {

        int[] freq1 = new int[26];
        int[] freq2 = new int[26];
        for(int i = 0; i<s.Length; i++)
        {
            int idx = s[i] - 'a';
            freq1[idx]++;
        }

        for(int i = 0; i<t.Length; i++)
        {
            int idx = t[i] - 'a';
            freq2[idx]++;
        }

        for(int i = 0; i<26; i++)
        {
            if(freq1[i]!=freq2[i])
                return false;
        }
        return true;
    }
}
