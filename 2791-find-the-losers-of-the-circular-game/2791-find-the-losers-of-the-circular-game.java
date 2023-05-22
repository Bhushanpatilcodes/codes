class Solution {
    public int[] circularGameLosers(int n, int k) {
        Set<Integer> visited = new HashSet<>();
        visited.add(0);
        int curr = 0;
        int round = 1;
    while(true){
        curr = curr + round*k;
        curr %= n;
        if(visited.contains(curr)){
            break;
        }
            visited.add(curr);
            round++;
        }
       int [] ans = new int[n-visited.size()];
       int ind = 0;
       for(int i=0; i<n; i++){
           if(visited.contains(i)){
               continue;
           }
               ans[ind++] = i+1;
           }
           return ans;

       } 
    }
        
    
