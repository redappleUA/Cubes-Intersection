using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Transform cube;
    private void Awake() => cube = gameObject.GetComponent<Transform>();
    void Start() => cube.localScale = new(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5));
}
