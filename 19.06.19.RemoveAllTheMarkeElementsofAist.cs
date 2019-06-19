/*

Define a method/function that removes from a given array of integers all the values contained in a second array.

Examples:
int[] integerList = new int[]{ 1, 1, 2, 3, 1, 2, 3, 4 }
int[] valuesList = new int[]{ 1, 3 }
Kata.Remove(integerList, valuesList) == new int[]{ 2, 2, 4 } // --> true

int[] integerList = new int[]{ 1, 1, 2 ,3 ,1 ,2 ,3 ,4, 4, 3 ,5, 6, 7, 2, 8 }
int[] valuesList = new int[]{ 1, 3, 4, 2 }
Kata.Remove(integerList, valuesList) == new int[]{ 5, 6 ,7 ,8 } // --> true

int[] integerList = new int[]{ 8, 2, 7, 2, 3, 4, 6, 5, 4, 4, 1, 2 , 3 }
int[] valuesList = new int[]{ 2, 4, 3 }
Kata.Remove(integerList, valuesList) == new int[]{ 8, 7, 6, 5, 1 } // --> true

 */


using System.Collections.Generic;
using System.Linq;


public class Kata
{
    public static int[] Remove(int[] integerList, int[] valuesList)
    {
        List<int> final = new List<int>();
        final = integerList.ToList();
        for (int j = 0; j < integerList.Length; j++)
        {
            for (int i = 0; i < valuesList.Length; i++)
            {
                if (valuesList[i] == integerList[j])
                {
                    final.Remove(valuesList[i]);
                }
            }
        }
        return final.ToArray<int>();
    }
}
    
  }
}