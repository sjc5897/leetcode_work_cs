// https://leetcode.com/problems/first-bad-version/submissions/
// public class FirstBadVersion{
//     public int FirstBadVersion(int n) {
//         int left = 0, right = n;
//         while(left <= right){
//             int middle = left + (right - left) / 2;
//             if(IsBadVersion(middle)){
//                 right = middle - 1;
//             }
//             else{
//                 left = middle + 1;
//             }
//         }
//         return left;
//     }
// }