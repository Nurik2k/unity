using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime*speed*vertical);
        transform.Rotate(Vector3.up, turnSpeed * horizontal * Time.deltaTime);
    }
}