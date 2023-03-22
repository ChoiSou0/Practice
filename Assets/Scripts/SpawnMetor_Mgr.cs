using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMetor_Mgr : MonoBehaviour
{
    [SerializeField] private List<GameObject> Metors = new List<GameObject>();
    private GameObject Player;
    [SerializeField] private int SpawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");


    }

    private IEnumerator SpawnMetor()
    {
        Instantiate(Metors[Random.Range(0, 3)]);
        yield break;
    }
}
