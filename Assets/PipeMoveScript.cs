using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    private float moveSpeed = 10;
    public float deadZone = -45;
 
    void Update()
    {
        transform.position+=(Vector3.left*moveSpeed)*Time.deltaTime;
        Debug.Log("pillar is present");

        if (transform.position.x <deadZone)
        {
           Destroy(gameObject);
        }
    }
}
