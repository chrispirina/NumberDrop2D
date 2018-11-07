using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawn : MonoBehaviour
{

    public RockSpawn instance;
    public GameObject rock;
    public GameObject playerPos;
    public bool destroyed = false;


    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Respawn()
    {
        if (destroyed == true)
        {
             Instantiate(rock);
            rock.transform.position = playerPos.transform.position;

            destroyed = false;
        }
    }
}
