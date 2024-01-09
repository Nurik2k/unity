using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject player;

    public Vector3 offset = new Vector3(0,5,-7);

    // Update is called once per frame
    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        transform.position = player.transform.position + offset;

        if(vertical == 0 && horizontal != 0){
            transform.Rotate(Vector3.up * Time.deltaTime * horizontal);
        }
    }
}
