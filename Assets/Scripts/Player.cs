using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Seamans
{

    private void FixedUpdate()
    {
        Move();
        Animate();
    }

    protected override void Move()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        base.Move();
    }


}
