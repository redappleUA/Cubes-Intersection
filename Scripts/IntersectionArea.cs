using UnityEngine;

public class IntersectionArea : MonoBehaviour
{
    [SerializeField] Renderer cube1;
    [SerializeField] Renderer cube2;
    [SerializeField] Transform intersection;

    CollideCheck collideCheck;

    void Update()
    {
        if (CollideCheck.GetIntersectionZone(cube1.bounds, cube2.bounds, out collideCheck))
        {
            intersection.gameObject.SetActive(true);

            intersection.position = collideCheck.bounds.center;
            intersection.localScale = collideCheck.bounds.size + (Vector3.one * 0.0001f);
        }
        else
            intersection.gameObject.SetActive(false);
    }
}