using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager Instance { get; private set; }

    public GameObject holeTemplate;
    public int holeCount = 6;

    private List<Hole> holes = new List<Hole>();

    private void Awake()
    {
        Instance = this;

        Transform holeAnchor = new GameObject("Holes").transform;

        for(int i = 0; i < holeCount; i++)
        {
            GameObject go = Instantiate(holeTemplate, holeAnchor);
            holes.Add(go.GetComponent<Hole>());
        }

        SpawnHoles();
    }

    public void HoleCollision(Hole hole)
    {

    }

    public void SpawnHoles()
    {
        foreach (Hole h in holes)
            h.transform.position = Vector3.one * -9999;

        foreach (Hole h in holes)
            h.Position(holes.Select(x => Mathf.RoundToInt(x.transform.position.x)).ToList());
    }
}
