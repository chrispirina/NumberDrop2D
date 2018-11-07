using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missed : MonoBehaviour {
    
    public GameObject rock;
    public GameObject playerObj;
    public float playerPos;
    public bool destroyed = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        
        Respawn();
    }

    private void Respawn()
    {
            Instantiate(rock);
        playerPos = playerObj.transform.position.x;
        rock.transform.position = new Vector2(0, 3.080534f);



    }
}
