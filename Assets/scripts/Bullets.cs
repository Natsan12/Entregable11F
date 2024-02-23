using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D Rb;

    private Vector2 Direction;
    
    void Start()

    {
        Rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rb.velocity=Direction*Speed;
    }

    public void SetDirection(Vector2 direction)
    {
        Direction = direction;


    }
}
