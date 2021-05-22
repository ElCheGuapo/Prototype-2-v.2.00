using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoRotate : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    public void FixedUpdate()
    {
        transform.Rotate((Vector3.up / 2), - speed * Time.deltaTime);
    }
}
