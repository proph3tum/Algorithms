namespace Algorithms;

public static class Entity
{
	private static int binary_search(int[] sortArray, int point)
	{
		var low = 0;
		int high = sortArray[^1] - 1;

		while (low <= high)
		{
			int mid = (low + high) / 2;
			int guess = sortArray[mid];
			
			if (guess == point) return mid;

			if (guess > point) high = mid - 1;
			else low = mid + 1;
		}

		return 0;
	}


	private static void Main()
	{
		int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		Console.WriteLine($"What number do you want to find in the array?");
		var point = Convert.ToInt32(Console.ReadLine());
		int foundNumber = binary_search(array, point);
		Console.WriteLine(foundNumber);
	}
}

