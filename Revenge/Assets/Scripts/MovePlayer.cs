using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float Speed;
    public float Jump;
    private Rigidbody2D rigid;
    public Transform GroundCheck;
    public float GroundCheckRadios;
    public LayerMask WhatIsGrounded;
    private bool Grounded;
    private bool DoubleJump;
    // Start is called before the first frame update
    void Start()
    {
    rigid =GetComponent<Rigidbody2D >(); 
    }
    private void FixedUpdate()
    {
        Grounded = Physics2D.OverlapCircle(GroundCheck.position,GroundCheckRadios,WhatIsGrounded);
    }
    // Update is called once per frame
    void Update()
    {
        if (Grounded) 
        DoubleJump = false;
        if (Input .GetKeyDown(KeyCode.Space)&&Grounded) 
        { 
        rigid.velocity =new Vector2 (rigid.velocity.y, Jump);
        }
        if (Input.GetKeyDown(KeyCode.Space) &&! DoubleJump &&! Grounded)
        {
            rigid.velocity = new Vector2 (rigid.velocity.y, Jump);
            DoubleJump = true;
        }
        if (Input .GetKey(KeyCode.D ))
        {
            rigid.velocity=new Vector2 (Speed , rigid.velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigid.velocity = new Vector2 (-Speed ,rigid.velocity.x );
        }
    }
}
