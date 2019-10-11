using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    public float gravityModifier = 1f;

    protected Rigidbody2D rigBody2d;
    protected Vector2 velocity;

    private void OnEnable()
    {
        rigBody2d = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        velocity += gravityModifier * Physics2D.gravity * Time.deltaTime;
        Vector2 deltaPos = velocity * Time.deltaTime;
        Vector2 move = Vector2.up * deltaPos.y;

        Movement(move);
    }

    private void Movement(Vector2 move)
    {
        rigBody2d.position += move;
    }
}
