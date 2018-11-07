using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missed : MonoBehaviour {
    RockSpawn rockSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rock"))
        {
            Destroy(other.gameObject);
            GameObject.Find("RightBounds").GetComponent<RockSpawn>().destroyed = true;
        }
    }
}
