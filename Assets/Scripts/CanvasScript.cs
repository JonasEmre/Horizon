using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    static CanvasScript instace;
    void Start()
    {
        if(instace != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instace = this;
        DontDestroyOnLoad(transform.gameObject);
    }
}
