public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] freq = new int[26];
        foreach (char t in tasks) 
            freq[t-'A']++;
        Array.Sort(freq);
        
        int maxFreq = freq[25];
        int countMaxFreq = 0;
        for(int i = 25; i >= 0;i--)
        {
            if(freq[i] == maxFreq)
                countMaxFreq++;
            else break;
        }
        Console.WriteLine(maxFreq);
        return Math.Max(tasks.Length, ((maxFreq-1)*(n+1)+countMaxFreq));
    }
}
