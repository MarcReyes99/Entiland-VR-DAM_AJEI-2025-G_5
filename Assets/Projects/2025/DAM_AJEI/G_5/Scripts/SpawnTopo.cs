using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTopo : MonoBehaviour
{
    public List<GameObject> topos;
    public bool isMissed;
    public float timer = 3f;
    public float spawnTIme = 15f;

    void Update()
    {

        SpawnPosition();  
    }

    private void SpawnPosition()
    {            
        int random = Random.Range(0,topos.Count);
        topos[random].SetActive(true);
    }

}
