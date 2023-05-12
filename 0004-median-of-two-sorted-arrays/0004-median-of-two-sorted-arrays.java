class Solution {
    public double findMedianSortedArrays(int[] num1, int[] num2) {
        int len = num1.length+num2.length;
        int [] merged = new int[len];

        int i =0;
        int j =0;
        int k =0;

        while(i <  num1.length  &&  j < num2.length){
                if(num1[i]<num2[j]){
                    merged[k] = num1[i];
                    i++;
                    k++;
                }else{
                    merged[k] = num2[j];
                    j++;
                    k++;
                }
        }
        while(i<  num1.length){
             merged[k] = num1[i];
                    i++;
                    k++;
        }
        while(j <  num2.length){
             merged[k] = num2[j];
                    j++;
                    k++;
        }
        double median =0.0;
        int mid = merged.length/2;

        if(merged.length % 2 == 1){
            median = merged[mid];
        }else{
            median = (merged[mid] + merged[mid-1])/2.0;
        }
        return median;
    
    }
}