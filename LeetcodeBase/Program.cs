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
Console.WriteLine("---Array6------");
int[] array7 = [8, 1, 2, 2, 3];
int[] result7 = solution.SmallerNumbersThanCurrent(array7);
foreach (int error in result7) { Console.WriteLine(error); }
Console.WriteLine("---Array7------");
int[] array8 = [6, 5, 4, 8];
int[] result8 = solution.SmallerNumbersThanCurrent(array8);
foreach (int error in result8) { Console.WriteLine(error); }