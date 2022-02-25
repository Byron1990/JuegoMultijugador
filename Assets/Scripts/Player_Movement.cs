using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player_Movement : NetworkBehaviour
{
    float moveSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isLocalPlayer)
        {   
            float x = Input.GetAxis("Horizontal") * moveSpeed;
            float z = Input.GetAxis("Vertical") * moveSpeed;
            transform.Translate(x, 0, z);
        }   
    }
}