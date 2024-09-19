using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MovePlayer : MonoBehaviour
{
    [Range(0f, 20f)]
    public float Speed;
    public Rigidbody rb;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float AxisVertical = Input.GetAxis("Vertical");
        if (Input.GetAxis("Vertical") != 0)
        {
            rb.velocity = new Vector3(transform.position.x * Speed * AxisVertical * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
