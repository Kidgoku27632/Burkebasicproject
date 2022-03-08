using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward;
        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.back;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.left;

        }
}
}
