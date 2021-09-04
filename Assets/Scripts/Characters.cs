using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Characters : MonoBehaviour
{

    [SerializeField] protected float moveSpeed;

    protected new Rigidbody2D rigidbody;
    protected Animator animator;

    protected float moveX;
    protected float moveY;

    protected Vector2 lastDirection;
    protected Vector2 moveDirection;

    protected virtual void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    protected virtual void Move()
    {
        if((moveX == 0 && moveY == 0) && (rigidbody.velocity.x != 0 || rigidbody.velocity.y != 0))
        {
            lastDirection = moveDirection;
        }
        moveDirection = new Vector2(moveX, moveY);
        rigidbody.velocity = moveDirection.normalized * moveSpeed * Time.deltaTime;
    }

    protected virtual void Animate()
    {
        animator.SetFloat("animX", moveX);
        animator.SetFloat("animY", moveY);
        animator.SetFloat("lastX", lastDirection.x);
        animator.SetFloat("lastY", lastDirection.y);
        animator.SetFloat("magnitute", moveDirection.magnitude);
    }


}
