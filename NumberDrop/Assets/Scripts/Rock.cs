using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public GameObject playerPos;
    public float speed = 0.5f;
    private bool isHeld = true;


    // Use this for initialization
    void Start()
    {
        transform.position = playerPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHeld == true)
        transform.position = playerPos.transform.position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isHeld = false;

        }

    }


}


