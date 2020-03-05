namespace UnityEngine
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this Object obj)
        {
            return ((object) obj) == null;
        }

        public static bool IsNotNull(this Object obj)
        {
            return ((object) obj) != null;
        }
    }
}
