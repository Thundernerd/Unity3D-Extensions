namespace System
{
    public static class ArrayExtensions
    {
        public static bool IsWithinBounds(this Array array, int i)
        {
            return IsWithinBounds(array, i, 0);
        }

        public static bool IsWithinBounds(this Array array, int i, int dimension)
        {
            int lower = array.GetLowerBound(dimension);
            int upper = array.GetUpperBound(dimension);
            return i >= lower && i <= upper;
        }
    }
}
