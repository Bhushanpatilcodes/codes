public class Solution {
   public IList<int> FindSubstring(string s, string[] words)
{
    var result = new List<int>();
    if (s == null || words == null || words.Length == 0) return result;

    int wordLen = words[0].Length;
    int wordCount = words.Length;
    int totalLen = wordLen * wordCount;

    var wordFreq = new Dictionary<string, int>();
    foreach (var word in words)
    {
        if (!wordFreq.ContainsKey(word))
            wordFreq[word] = 0;
        wordFreq[word]++;
    }

    for (int i = 0; i < wordLen; i++)
    {
        int left = i, count = 0;
        var window = new Dictionary<string, int>();

        for (int j = i; j <= s.Length - wordLen; j += wordLen)
        {
            string word = s.Substring(j, wordLen);

            if (wordFreq.ContainsKey(word))
            {
                if (!window.ContainsKey(word))
                    window[word] = 0;
                window[word]++;
                count++;

                // Shrink the window if word count exceeds frequency
                while (window[word] > wordFreq[word])
                {
                    string leftWord = s.Substring(left, wordLen);
                    window[leftWord]--;
                    count--;
                    left += wordLen;
                }

                if (count == wordCount)
                    result.Add(left);
            }
            else
            {
                // Reset window
                window.Clear();
                count = 0;
                left = j + wordLen;
            }
        }
    }

    return result;
}
}