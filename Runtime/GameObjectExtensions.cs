namespace UnityEngine
{
    public static class GameObjectExtensions
    {
        public static void SetParent(this GameObject gameObject, GameObject parent)
        {
            gameObject.transform.SetParent(parent.transform);
        }

        public static void SetParent(this GameObject gameObject, GameObject parent, bool worldPositionStays)
        {
            gameObject.transform.SetParent(parent.transform, worldPositionStays);
        }
    }
}
