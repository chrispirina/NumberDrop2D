using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 0.25f;
    public GameObject rock;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //movement
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-speed, 0, 0);
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(speed, 0, 0);
        
        
    }
}
