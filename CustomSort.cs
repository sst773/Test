namespace _01_CustomSort
{
    using System;

    public static class CustomSort
    {
        public static void Sort<T>(ref T[] array, Func<T, T, int> greaterThanDel)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (greaterThanDel.Invoke(array[j], array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static int GreaterThan<T>(T left, T right)
            where T : IComparable
        {
            return left.CompareTo(right);
        }
    }
}