using UnityEngine;

public class CollideCheck
{
    private Vector3 min;
    private Vector3 max;
    public readonly Bounds bounds;

    private CollideCheck(Bounds cube1Bounds, Bounds cube2Bounds)
    {
        Vector3 cube1_min = cube1Bounds.min;
        Vector3 cube1_max = cube1Bounds.max;
        Vector3 cube2_min = cube2Bounds.min;
        Vector3 cube2_max = cube2Bounds.max;

        min.x = Mathf.Max(cube1_min.x, cube2_min.x);
        min.y = Mathf.Max(cube1_min.y, cube2_min.y);
        min.z = Mathf.Max(cube1_min.z, cube2_min.z);

        max.x = Mathf.Min(cube1_max.x, cube2_max.x);
        max.y = Mathf.Min(cube1_max.y, cube2_max.y);
        max.z = Mathf.Min(cube1_max.z, cube2_max.z);

        bounds.SetMinMax(min, max);
    }

    public static bool GetIntersectionZone(Bounds cube1Bounds, Bounds cube2Bounds, out CollideCheck collideCheck)
    {
        if (cube1Bounds.Intersects(cube2Bounds))
        {
            collideCheck = new(cube1Bounds, cube2Bounds);
            return true;
        }
        else
        {
            collideCheck = null;
            return false;
        }
    }
}