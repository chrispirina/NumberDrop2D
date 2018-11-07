using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public GameObject playerPos;
    public bool isHeld = true;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isHeld)
            transform.position = playerPos.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isHeld = false;
            
        }
		
	}

  
}
