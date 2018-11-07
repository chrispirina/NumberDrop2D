using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missed : MonoBehaviour {

    public static Missed instance;

    public GameObject rock;
    public GameObject playerObj;
    public bool destroyed = false;

    private void Awake()
    {
        instance = this;
    }
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

    public void Respawn()
    {
            Instantiate(rock).GetComponent<Rock>().playerPos = playerObj;
        



    }
}
