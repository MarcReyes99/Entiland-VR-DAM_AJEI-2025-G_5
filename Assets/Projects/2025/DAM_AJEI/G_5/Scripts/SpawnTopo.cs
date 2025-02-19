using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTopo : MonoBehaviour
{
    public GameObject[] topos;
    public bool isMissed;
    public float timer = 3f;

    void Update()
    {
        SpawnPosition();  
    }

    private void SpawnPosition()
    {            
        int random = Random.Range(0,topos.Length);
        topos[random].SetActive(true);
    }

}
