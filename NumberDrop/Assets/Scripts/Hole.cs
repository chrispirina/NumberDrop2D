using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    
    void NumberDisplay()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Destroy(this.gameObject);
        Missed.instance.Respawn();

    }
}
