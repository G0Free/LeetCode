using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    static class ReorderDatainLogFilesProblem
    {
        #region ProblemDescription
        //937. Reorder Data in Log Files
        //You are given an array of logs. Each log is a space-delimited string of words, where the first word is the identifier.

        //There are two types of logs:

        //Letter-logs: All words(except the identifier) consist of lowercase English letters.
        //Digit-logs: All words(except the identifier) consist of digits.

        //Reorder these logs so that:
        //The letter-logs come before all digit-logs.
        //The letter-logs are sorted lexicographically by their contents.If their contents are the same, then sort them lexicographically by their identifiers.
        //The digit-logs maintain their relative ordering.
        //Return the final order of the logs.

        //Example 1:
        //Input: logs = ["dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"]
        //Output: ["let1 art can","let3 art zero","let2 own kit dig","dig1 8 1 5 1","dig2 3 6"]
        //Explanation:
        //The letter-log contents are all different, so their ordering is "art can", "art zero", "own kit dig".
        //The digit-logs have a relative order of "dig1 8 1 5 1", "dig2 3 6".

        //Example 2:
        //Input: logs = ["a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo"]
        //Output: ["g1 act car","a8 act zoo","ab1 off key dog","a1 9 2 3 1","zo4 4 7"]


        //Constraints:

        //1 <= logs.length <= 100
        //3 <= logs[i].length <= 100
        //All the tokens of logs[i] are separated by a single space.
        //logs[i] is guaranteed to have an identifier and at least one word after the identifier.
        #endregion

        static public string[] ReorderLogFiles(string[] logs)
        {
            int N = logs.Length;

            int LastLetPosition = 0;
            //Reoerdering to letter-logs come before digit-logs.
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (logs[i].Split(' ')[0].Contains("dig") && logs[j].Split(' ')[0].Contains("let"))
                    {
                        Swap(logs, i, j);
                        LastLetPosition = i;
                    }
                }
            }
            ;
            //Example outcome :
            //let1 art can,
            //let2 own kit dig,
            //let3 art zero,
            //dig1 8 1 5 1,
            //dig2 3 6

            //Now we can reorder the two part.
            //letter part 
            for (int i = 0; i < (LastLetPosition + 1 - 1); i++)
            {
                for (int j = i + 1; j < LastLetPosition + 1; j++)
                {

                }
            }

            //digit part
            for (int j = (LastLetPosition + 1); j < N; j++)
            {

            }

            return logs;
        }

        /*  static public string[] ReorderLogFiles(string[] logs)
          {
              int N = logs.Length;
              for (int i = 0; i < N - 1; i++)
              {
                  for (int j = i + 1; j < N; j++)
                  {
                      if (logs[i].Split(' ')[0].Contains("dig")) //digit-log
                      {
                          int seeker = i;
                          while (logs[seeker].Split(' ')[0].Contains("dig") && seeker < N)
                          {
                              seeker++;
                          }
                          if (seeker < N)
                          {
                              if (Comparing(logs[i], logs[seeker]) < 0)
                              {
                                  //logs[i] > logs[seeker]
                                  Swap(logs, i, seeker);
                              }
                              else if(Comparing(logs[i], logs[seeker]) > 0)
                              {
                                  //logs[i] < logs[seeker]
                                  Swap(logs, seeker, i);
                              }
                              else
                              {
                                  //logs[i] = logs[seeker]
                              }
                          }
                      }
                      else
                      {

                      }
                  }
              }


              return logs;
          }

          static private int Comparing(string a, string b)
          {

              return 0;
          }
        */

        static private void Swap(string[] logs, int indexA, int indexB)
        {
            string tmp = logs[indexA];
            logs[indexA] = logs[indexB];
            logs[indexB] = tmp;
        }


    }
}
