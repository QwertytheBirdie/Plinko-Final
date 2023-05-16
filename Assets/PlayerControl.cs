using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;
    //Vector3 currentPos;
    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {
        Vector3 currentPos = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            currentPos.x += 0.5f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            currentPos.x = currentPos.x - speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            currentPos.z = currentPos.z + speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            currentPos.z = currentPos.z - speed * Time.deltaTime;
        }


        transform.position = currentPos;
    }
}

