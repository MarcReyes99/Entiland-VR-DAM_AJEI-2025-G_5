using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTopo : MonoBehaviour
{
    public List<GameObject> puntosDeSpawn;

    public static SpawnTopo instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }

        DontDestroyOnLoad(this);
    }

}
