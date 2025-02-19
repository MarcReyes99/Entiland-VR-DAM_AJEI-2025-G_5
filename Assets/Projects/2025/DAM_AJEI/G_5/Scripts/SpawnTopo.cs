using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTopo : MonoBehaviour
{
    public List<GameObject> topos;
    public bool isMissed;
    public float timer = 3f;
    public float spawnTime = 0f;
    public float spawnedTime = 4f;

    //void Update()
    //{
    //    spawnTime += Time.deltaTime;
    //    if (spawnTime >= spawnedTime)
    //    {
    //        SpawnPosition();  
    //        spawnTime = 0f;
    //    }
    //}

    //private void SpawnPosition()
    //{            
    //    int random = Random.Range(0,topos.Count);
    //    topos[random].SetActive(true);
    //    timer += Time.deltaTime;
    //    if (timer >= 3)
    //    {
    //        topos[random].SetActive(false);
    //        timer = 0f;
    //    }

    //}

}
