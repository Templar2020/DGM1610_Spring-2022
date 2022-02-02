using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,2,-4);

    void FixedUpdate()
    {
        // Follow Players position
       transform.position = player.transform.position + offset; 
    }
    
}
