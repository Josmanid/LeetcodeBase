using LeetcodeBase;

//Array 1.1
Solution solution = new Solution();
int[] array1 = [1, 2, 1];
int[] result = solution.GetConcatenation(array1);
Console.WriteLine(result);

foreach (int results in result)
{
    Console.WriteLine(results);
}
Console.WriteLine("---Array2------");
//Array 1.2
int[] array2 = [1, 2, 3, 4, 4, 3, 2, 1];
int n = 4;
int[] result2 = solution.Shuffle(array2, n);

foreach (int results2 in result2) { Console.WriteLine(results2); }
//Array 1.3 find maxcount
Console.WriteLine("---Array3------");
int[] array3 = [1, 1, 0, 1, 1, 1];
int result3 = solution.FindMaxConsecutiveOnes(array3);
Console.WriteLine(result3);
Console.WriteLine("---Array3.2------");
int[] array4 = [1, 0, 1, 1, 0, 1];
int result4 = solution.FindMaxConsecutiveOnes(array4);
Console.WriteLine(result4);

//Array 2.1 find FindErrorNums
Console.WriteLine("---Array4------");
int[] array5 = [1, 2, 2, 4];
int[] result5 = solution.FindErrorNums(array5);
foreach (int error in result5) { Console.WriteLine(error); }
Console.WriteLine("---Array5------");
int[] array6 = [1, 1,];
int[] result6 = solution.FindErrorNums(array6);
foreach (int error in result6) { Console.WriteLine(error); }

//Array 2.2 find SmallerNumbersThanCurrent
Console.WriteLine("---Array7------");
int[] array7 = [8, 1, 2, 2, 3];
int[] result7 = solution.SmallerNumbersThanCurrent(array7);
foreach (int error in result7) { Console.WriteLine(error); }
Console.WriteLine("---Array8------");
int[] array8 = [6, 5, 4, 8];
int[] result8 = solution.SmallerNumbersThanCurrent(array8);
foreach (int error in result8) { Console.WriteLine(error); }

//Array 2.3 find FindDisappearedNumbers
Console.WriteLine("---Array9------");
int[] array9 = [4, 3, 2, 7, 8, 2, 3, 1];
IList<int> result9 = solution.FindDisappearedNumbers(array9);
foreach (int error in result9) { Console.WriteLine(error); }
Console.WriteLine("---Array10------");
int[] array10 = [1, 1,];
IList<int> result10 = solution.FindDisappearedNumbers(array10);
foreach (int error in result10) { Console.WriteLine(error); }

//Stringbuilder training
Console.WriteLine("--------String merge------");
string word1 = "abc";
string word2 = "pqr";
string mergedString = solution.MergeAlternately(word1, word2);
Console.WriteLine(mergedString);

string word3 = "ab";
string word4 = "pqrs";
string mergedString2 = solution.MergeAlternately(word3, word4);
Console.WriteLine(mergedString2);

string word5 = "abcd";
string word6 = "pq";
string mergedString3 = solution.MergeAlternately(word5, word6);
Console.WriteLine(mergedString3);


// Char finding the difference
Console.WriteLine("--------Char merge------");
string s = "abcd";
string t = "abcde";
char addedLetter1 = solution.FindTheDifference(s, t);
Console.WriteLine(addedLetter1);

string s2 = "";
string t2 = "y";
char addedLetter2 = solution.FindTheDifference(s2, t2);
Console.WriteLine(addedLetter2);












Console.ReadKey();
