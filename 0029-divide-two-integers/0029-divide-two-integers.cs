public class Solution {
    public int Divide(int dividend, int divisor) {
        if(dividend == int.MinValue && divisor == -1)
        return int.MaxValue;
          
        
        long lDividend = Math.Abs((long)dividend);
        long lDivisor = Math.Abs((long)divisor);
        long result = 0;

    while(lDividend >= lDivisor)
    {
        long temp = lDivisor , multiple =1;

        while(lDividend >= (temp << 1))
        {
            temp <<=1;
            multiple <<=1;
        } 

        lDividend -= temp;
        result += multiple;
    }

    bool isNegative = (dividend <0 ) ^ (divisor <0);
    return isNegative ? (int)-result : (int)result;

    }
}