using UnityEngine;

public static class MathExtensions
{
    public static int Clamp(this int value, int min, int max)
    {
        return Mathf.Clamp(value, min, max);
    }

    public static float Clamp(this float value, float min, float max)
    {
        return Mathf.Clamp(value, min, max);
    }
}
