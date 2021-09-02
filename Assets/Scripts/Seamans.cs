using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seamans : Characters
{
    protected new string name;
    protected float leadership;
    protected float seamanship;
    protected float tradesmanship;

    public string Name{
        get
        {
            return this.name;
        }
     }
}
