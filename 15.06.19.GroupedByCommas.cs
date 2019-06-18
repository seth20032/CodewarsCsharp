/* Finish the solution so that it takes an input n (integer) and returns a string that is the decimal representation of the number grouped by commas after every 3 digits.

Assume: 0 <= n < 2147483647

Examples
       1  ->           "1"
      10  ->          "10"
     100  ->         "100"
    1000  ->       "1,000"
   10000  ->      "10,000"
  100000  ->     "100,000"
 1000000  ->   "1,000,000"
35235235  ->  "35,235,235"

*/


######Solution 1######
using System;

public static class Kata
{
  public static string GroupByCommas(int n)
  {
    
    return  n.ToString("n0");
    
    throw new NotImplementedException();
  }
  
  
}


######Solution 2######
using System;

public static class Kata
{
  public static string GroupByCommas(int n)
  {
    string mystring = n.ToString("n0");
    return  mystring;
    
    throw new NotImplementedException();
  }
  
}
