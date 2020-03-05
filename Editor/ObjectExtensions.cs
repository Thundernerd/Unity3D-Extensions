using UnityEngine;

namespace UnityEditor
{
    public static class ObjectExtensions
    {
        public static string GetAssetPath(this Object obj)
        {
            return AssetDatabase.GetAssetPath(obj);
        }

        public static string GetAssetGuid(this Object obj)
        {
            return AssetDatabase.AssetPathToGUID(GetAssetPath(obj));
        }
    }
}
