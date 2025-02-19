using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topo : MonoBehaviour
{
    public float spawnTime = 0f;
    public float spawnedTime = 4f;

    void Update()
    {
        spawnTime += Time.deltaTime;

        if (spawnTime >= spawnedTime)
        {
            if (gameObject.GetComponent<MeshRenderer>().enabled)
            {
                Disappear();
            }
            else
            {
                Appear();
            }
            spawnTime = 0f;
        }
    }

    public void Appear()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    public void Disappear()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    public void Hit()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        spawnTime = 0f;
    }

    
}
