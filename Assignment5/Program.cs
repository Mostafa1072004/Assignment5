namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 .Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("please enter the matrix : ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[,] arr;
            //arr = new int[size,size];
            //for (int i = 0; i <size; i++)
            //{
            //    for (int j = 0 ; j < size; j++)
            //    {
            //        int.TryParse(Console.ReadLine(), out  arr[i,j] );
            //    }

            //}
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0 ;j < size; j++)              
            //        Console.Write($" {arr[i,j]}     ");
            //    Console.WriteLine("");


            //}


            #endregion

            #region 2 .Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.WriteLine("please enter size of array : ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr;
            //arr = new int[size];
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"please enter number {i+1} : ");
            //    int.TryParse(Console.ReadLine(), out  arr[i]);
            //    sum += arr[i];
            //}
            //Console.WriteLine($"the sum all element = {sum}");
            #endregion

            #region 3 .Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.WriteLine("please enter size of array1 : ");
            //int.TryParse(Console.ReadLine(), out int size1);
            //int[] arr1;
            //arr1 = new int[size1];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine($"please enter number of array (1) {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out arr1[i]);

            //}
            //Console.WriteLine("please enter size of array2 : ");
            //int.TryParse(Console.ReadLine(), out int size2);
            //int[] arr2;
            //arr2 = new int[size2];
            //for (int j = 0; j < arr1.Length; j++)
            //{
            //    Console.WriteLine($"please enter number of array (2) {j + 1} : ");
            //    int.TryParse(Console.ReadLine(), out arr2[j]);

            //}
            //int[] mergedArray = new int[arr1.Length + arr2.Length];
            //int index = arr1.Length;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    mergedArray [i] = arr1[i];
            //}
            //for (int j = 0; j < arr2.Length; j++)
            //{
            //    mergedArray[index++] = arr2[j];
            //}
            //Console.Write($"Merged  => ");
            //for (int i = 0;i < mergedArray.Length; i++)
            //{
            //    Console.Write($" {mergedArray[i]} ");
            //}
            #endregion

            #region  4 .Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.WriteLine("please enter size of array : ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //int count = 0;
            //Console.WriteLine("please enter array element : ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //for (int i = 0;i < arr.Length-1; i++)
            //{
            //     if (arr[i] == arr[i+1])
            //            count++;
            //}
            //Console.WriteLine($"count => {count}");

            #endregion

            #region 5.Write a program in C# Sharp to find maximum and minimum element in an array.
            //Console.WriteLine("please enter size of array : ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //int max = int.MaxValue;
            //int min = int.MaxValue;
            //Console.WriteLine("please enter array element : ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"Max = {max}");
            //Console.WriteLine($"min = {min}");
            #endregion

            #region 6 . Write a program in C# Sharp to find the second largest element in an array.
            //Console.WriteLine("please enter size of array : ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //Console.WriteLine("please enter array element : ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //Array.Sort(arr);

            ////Console.WriteLine($"Scound Max = {arr[arr.Length-2]}");
            #endregion

            #region 7 . Consider an Array of Integer values with size N, having values as 
            //Console.WriteLine("please enter size of array : ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //int count = 0;
            //Console.WriteLine("please enter array element : ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i; 
            //            if (distance > count)
            //            {
            //                count = distance;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"Count of consecutive duplicate elements: {count-1}");
            #endregion

            #region 8 . Given a list of space separated words, reverse the order of the words.
            //string words;
            //words = Console.ReadLine();
            //string[] arr = words.Split(' ');
            //Array.Reverse(arr);
            //words = string.Join(" ", arr);
            //Console.WriteLine(words);

            #endregion

            #region 9 . Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
            //Console.WriteLine("enter num of row and col:");
            //int.TryParse(Console.ReadLine(), out int Row);
            //int.TryParse(Console.ReadLine(), out int Col);

            //int[,] firstArray = new int[Row, Col];
            //int[,] secondArray = new int[Row, Col];

            //Console.WriteLine("enter elements of array:");

            //for (int i = 0; i < Row; i++)
            //{
            //    for (int j = 0; j < Col; j++)
            //    {
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < Row; i++)
            //{
            //    for (int j = 0; j < Col; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}
            //Console.WriteLine("first array:");

            //for (int i = 0; i < Row; i++)
            //{
            //    for (int j = 0; j < Col; j++)
            //    {
            //        Console.Write(firstArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Second array:");

            //for (int i = 0; i < Row; i++)
            //{
            //    for (int j = 0; j < Col; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 10 . Write a Program to Print One Dimensional Array in Reverse Order
            //Console.WriteLine("Enter Size Of Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //Console.WriteLine("Enter The Elements: ");

            //for (int i = 0; i < size; i++)
            //    int.TryParse(Console.ReadLine(), out arr[i]);

            //Console.Write($"Array in Reverse: ");
            ////Array.Reverse(arr);
            ////for (int i = 0; i < arr.Length ; i++)
            ////    Console.Write($"{arr[i]} ");

            //for (int i = arr.Length - 1; i >= 0; i--)
            //    Console.Write($"{arr[i]} ");

            #endregion

        }
    }
}
