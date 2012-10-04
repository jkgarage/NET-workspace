using System;
namespace Solution
{
   class Solution
   {
       static void Main(string[] args)
       {
           string line1 = System.Console.ReadLine().Trim();
           int T = Int32.Parse(line1);
           for (int i = 0; i < T; i++)
           {
               string lineDetail = System.Console.ReadLine().Trim();
               System.Console.WriteLine(ProcessInput(lineDetail));
           }

           System.Console.ReadLine();
       }
       /********************************/
       static string ProcessInput(string lineDetail)
       {
           char[] originalCharArray = lineDetail.ToCharArray();
           char[] suffixCharArray = new char[originalCharArray.Length];
           Array.Copy(originalCharArray, suffixCharArray, originalCharArray.Length);

           int totalSimilarities = 0;
           int individualSimilarity = -1;
           for (int currCursor = 0; currCursor < lineDetail.Length; currCursor++)
           {
               individualSimilarity = -1;
               //this is to mark for each suffix
               for (int secCursor = currCursor; secCursor < lineDetail.Length; secCursor++)
               {
                   if (originalCharArray[secCursor - currCursor] != suffixCharArray[secCursor] )
                   {
                       individualSimilarity = secCursor - currCursor;
                       break;
                   }
               }
               if (individualSimilarity == -1)
                   individualSimilarity = lineDetail.Length - currCursor;
               totalSimilarities += individualSimilarity;
           }

           return totalSimilarities.ToString();
       }
     
   }
}
