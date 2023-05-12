class Solution {
   
        public String longestPalindrome(String s) {
    if (s.length() < 2) {
        return s;
    }
    int start = 0, end = 0;
    for (int i = 0; i < s.length(); i++) {
        // check for palindromes with center as single character
        int len1 = expandAroundCenter(s, i, i);
        // check for palindromes with center as pair of characters
        int len2 = expandAroundCenter(s, i, i+1);
        int length = Math.max(len1, len2);
        if (length > end - start) {
            start = i - (length - 1) / 2;
            end = i + length / 2;
        }
    }
    return s.substring(start, end+1);
}

private int expandAroundCenter(String s, int left, int right) {
    while (left >= 0 && right < s.length() && s.charAt(left) == s.charAt(right)) {
        left--;
        right++;
    }
    return right - left - 1;
}
    
}