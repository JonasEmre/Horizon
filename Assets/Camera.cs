using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject currentPlayer;

    void Start()
    {
        currentPlayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(currentPlayer.transform.position.x, currentPlayer.transform.position.y, -10f);
    }
}
