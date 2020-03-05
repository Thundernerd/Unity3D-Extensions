namespace System
{
    public static class ArrayExtensions
    {
        public static bool IsWithinBounds(this Array array, int i)
        {
            return i >= 0 && i < array.Length;
        }
    }
}
