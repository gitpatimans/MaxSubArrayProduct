# MaxSubArrayProduct
**Problem Statement** -
Out of 'N' programming languagesUser knew 'M' programming languages .
Here, Input would be Array of size n representing values 1 if user knew the programming language;
-1 if user dont know the programming language.

Sample Input 
N = 6;
arr[N] = { 1, -1, -1, -1, 1, 1 };

OutPut = 4

**Explaination**
Write a code which would return maximum subarray length whose product would be 1.
e.g. for above given input
a. Product of consecutive array elements from index 0 to index 2 (1*-1*-1) = 1 so the length = 3
b. Product of consecutive array elements from index 1 to index 2 (-1*-1) = 1 so the length = 2 
c. Product of consecutive array elements from index 2 to index 3 (-1*-1) = 1 so the length = 2
d. Product of consecutive array elements from index 2 to index 4 (-1*-1*1) = 1 so the length = 3
e. Product of consecutive array elements from index 2 to index 5 (-1*-1*1*1) = 1 so the length = 4
f. Product of consecutive array elements from index 4 to index 5 (1*1) = 1 so the length = 2

So, the Maximum SubArray Product Length is 4 hence the Output is 4
