using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector3 position;
    public float offsetX = 0f;
    public float offsetY = 0f;
    public float offsetZ = 0f;
    private void Update()
    {
        position.x = rb.position.x + offsetX;
        position.y = rb.position.y + offsetY;
        position.z = offsetZ;
    }
    private void FixedUpdate()
    {
        transform.position = position;
    }
}
