using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public Vector2Int min;
    public Vector2Int max;

    private int number;
    public int Number { get
        {
            return number;
        }
        set
        {
            number = value;
            text.text = value.ToString();
        }
    }

    private TextMeshPro text;

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshPro>();
    }
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void Position(List<int> xVals)
    {
        int x;
        do
        {
            x = Random.Range(min.x, max.x);
        } while (xVals.Contains(x));

        transform.position = new Vector3(x, Random.Range(min.y, max.y + 1));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        Missed.instance.Respawn();
    }
}
