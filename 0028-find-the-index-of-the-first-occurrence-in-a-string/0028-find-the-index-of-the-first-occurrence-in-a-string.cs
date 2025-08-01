public class Solution {
    public int StrStr(string haystack, string needle) {

        int result = -1;
        if(needle.Length < haystack.Length)
        {
            for(int i = 0; i<= haystack.Length - needle.Length; i++)
            {
                if(haystack[i] == needle[0])
                {
                    result = i;
                    for(int j =1; j<needle.Length ; j++)
                    {
                        if(haystack [i+j] != needle[j])
                        {
                            result = -1;
                            break;
                        }
                    }
                    if(result != -1)
                    {
                        break;
                    }
                }
            }
        }
        else if(needle == haystack)
        {
            return 0;
        }
        return result;
    }
}