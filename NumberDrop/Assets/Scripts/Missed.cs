using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missed : MonoBehaviour {
    
    public GameObject rock;
    public GameObject playerPos;
    public bool destroyed = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        
        Respawn();
    }

    private void Respawn()
    {
            Instantiate(rock);
            rock.transform.position = playerPos.transform.position;

    }
}
