using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Seamans
{

    static Player instace;

    protected override void Start()
    {
        base.Start();
        if(instace != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instace = this;
        DontDestroyOnLoad(this.gameObject);
    }

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
