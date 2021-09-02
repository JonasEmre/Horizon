using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private Animator animtor;

    [SerializeField] private float moveSpeed;

    private float moveX;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animtor = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();
        Animate();
    }

    private void Move()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        rigidbody.velocity = new Vector2(moveX, 0) * moveSpeed * Time.deltaTime ;
    }

    private void Animate()
    {
        animtor.SetFloat("animX", moveX);
    }
}
