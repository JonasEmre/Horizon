using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    private GameObject currentPlayer;
    static CameraBehaviour instance;

    void Start()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        currentPlayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPlayer)
        {
            transform.position = new Vector3(currentPlayer.transform.position.x, currentPlayer.transform.position.y, -10f);
        }
    }
}
