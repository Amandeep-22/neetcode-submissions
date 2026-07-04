public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        List<List<string>> ans = new List<List<string>>();
        Dictionary<string, List<string>> dict =  new Dictionary<string, List<string>>();
        foreach(string str in strs)
        {
            int[] freq = new int[26];

            for(int i = 0; i<str.Length; i++)
            {
                int idx = str[i] - 'a';
                freq[idx]++;
            }

            string key = string.Join(",", freq);
            List<string> val;
            if(dict.ContainsKey(key))
            {
                val = dict[key];
            }
            else
            {
                val = new List<string>();
            }
            val.Add(str);
            dict[key] = val;
        }
        return dict.Values.ToList<List<string>>();
    }
}
