/*using System;

namespace TwoDimensionalArraySorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|=================================================================|");
            Console.WriteLine("\tARRAY SORTER");
            Console.WriteLine("|=================================================================|");
            Console.WriteLine();

            // Get array size from the user
            int rowCount = GetValidatedArraySize();

            // Create the array
            int[,] array = new int[rowCount, 2];

            // Get array elements from the user
            GetArrayElements(array);

            // Display the entered array
            Console.WriteLine("You have entered below array values:");
            DisplayArray(array);

            // Get sorting column and order from the user
            char sortingColumn = GetSortingColumn();
            int sortingOrder = GetSortingOrder();

            // Sort the array
            SortArray(array, sortingColumn, sortingOrder);

            // Display the sorted array
            Console.WriteLine("\nSorted 2D array:");
            DisplayArray(array);
        }

        static int GetValidatedArraySize()
        {
            while (true)
            {
                Console.Write("Input array row count [1 to 10]: ");
                string input = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int size) || size < 1 || size > 10)
                {
                    Console.WriteLine("Error: Entered array size is invalid.");
                    Console.WriteLine("Please enter a valid integer between 1 and 10.");
                    continue;
                }

                return size;
            }
        }

        static void GetArrayElements(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"Enter element for [{i}, 0]: ");
                string input1 = Console.ReadLine().Trim();
                if (!int.TryParse(input1, out array[i, 0]))
                {
                    Console.WriteLine("Error: Entered array element is invalid.");
                    Console.WriteLine("Please enter a valid integer.");
                    i--;
                    continue;
                }

                Console.Write($"Enter element for [{i}, 1]: ");
                string input2 = Console.ReadLine().Trim();
                if (!int.TryParse(input2, out array[i, 1]))
                {
                    Console.WriteLine("Error: Entered array element is invalid.");
                    Console.WriteLine("Please enter a valid integer.");
                    i--;
                    continue;
                }
            }
        }

        static void DisplayArray(int[,] array)
        {
            Console.WriteLine("\tX\tY");
            Console.WriteLine("\t-------------");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"\t{array[i, 0]}\t{array[i, 1]}");
            }
        }

        static char GetSortingColumn()
        {
            while (true)
            {
                Console.Write("On which column you want to sort (Enter X/x or Y/y): ");
                string input = Console.ReadLine().Trim().ToLower();

                if (string.IsNullOrWhiteSpace(input) || (input != "x" && input != "y"))
                {
                    Console.WriteLine("Error: Entered sorting column is invalid.");
                    Console.WriteLine("Please enter 'X' or 'Y'.");
                    continue;
                }

                return Char.ToUpper(input[0]);
            }
        }

        static int GetSortingOrder()
        {
            while (true)
            {
                Console.Write("Which sorting type you want to apply (Enter 1 for Ascending sorting, 2 for Descending sorting): ");
                string input = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int order) || (order != 1 && order != 2))
                {
                    Console.WriteLine("Error: Entered sorting order is invalid.");
                    Console.WriteLine("Please enter '1' for Ascending or '2' for Descending.");
                    continue;
                }

                return order;
            }
        }

        static void SortArray(int[,] array, char sortingColumn, int sortingOrder)
        {
            int rowCount = array.GetLength(0);

            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < rowCount - i - 1; j++)
                {
                    bool shouldSwap = ShouldSwap(array[j, sortingColumn - 'X'], array[j + 1, sortingColumn - 'X'], sortingOrder);

                    if (shouldSwap)
                    {
                        // Swap rows
                        for (int k = 0; k < 2; k++)
                        {
                            int temp = array[j, k];
                            array[j, k] = array[j + 1, k];
                            array[j + 1, k] = temp;
                        }
                    }
                }
            }
        }

        static bool ShouldSwap(int a, int b, int sortingOrder)
        {
            if (sortingOrder == 1)
                return a > b;
            else
                return a < b;
        }
    }
}
*/




namespace App {

    class Program { 
    
    public static void Main(string[] args) {


            GetValidateArraySize();
        
        
        
        }
        public static void GetValidateArraySize()
        {
            while (true) {
                Console.WriteLine("input Array row Count:");
                string rowCount= Console.ReadLine();

                if (string.IsNullOrWhiteSpace(rowCount))
                {
                    Console.WriteLine("Array size is invalid");
                    continue;
                }
                if (!int.TryParse(rowCount, out int RowSize)) {
                    Console.WriteLine("Array size is invalid");
                    continue;
                }
                if (!outOfArray(RowSize))
                { 
                Console.WriteLine("out of Range");
                    continue; 
                }
            
            }



        }
        public static bool outOfArray(int RowSize) {
            if (RowSize>10)
            {
                return false;  
            }
            return true;    
        }
    
    }

}