using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rigidbody;
    public KeyCode Up;
    public KeyCode Down;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(Up))
        {
            
            rigidbody.velocity = new Vector2(0, moveSpeed);
        }
        else if (Input.GetKey(Down))
        {
            
            rigidbody.velocity = new Vector2(0, -moveSpeed);
        }
        else
        {
            rigidbody.velocity = new Vector2(0, 0);
        }
    }
}