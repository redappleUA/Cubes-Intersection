using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    [SerializeField] float turnSpeed = 4f;
    private GeneratedCubeControl controller;
    private Rigidbody rb;

    void Awake()
    {
        controller = new();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var moveDirection = controller.Move.Movement.ReadValue<Vector3>();
        //rb.AddForce(new Vector3(moveDirection.x, moveDirection.z, moveDirection.y) * turnSpeed);
        rb.velocity = moveDirection;
    }

    private void OnEnable() => controller.Enable();
    private void OnDisable() => controller?.Disable();
}
