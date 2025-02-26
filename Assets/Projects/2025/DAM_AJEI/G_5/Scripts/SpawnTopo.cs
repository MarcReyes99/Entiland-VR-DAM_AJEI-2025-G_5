using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTopo : MonoBehaviour
{
    public List<GameObject> toposBuenos;
    public List<GameObject> toposMalos;
    public List<Transform> puntosDeSpawn;

    public float spawnTime = 0f;
    public float spawnedTime = 4f;
    public float tiempoDesaparicion = 3f;

    void Start()
    {
        DesactivarTopos();
    }

    void Update()
    {
        spawnTime += Time.deltaTime;

        if (spawnTime >= spawnedTime)
        {
            SpawnTopos();
            spawnTime = 0f;
        }
    }

    void SpawnTopos()
    {
        DesactivarTopos();

        int cantidadToposBuenos = Random.Range(1, 6);
        int cantidadToposMalos = Random.Range(1, 6);

        SpawnToposDeTipo(toposBuenos, cantidadToposBuenos);

        SpawnToposDeTipo(toposMalos, cantidadToposMalos);
    }

    void SpawnToposDeTipo(List<GameObject> listaTopos, int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            if (puntosDeSpawn.Count > 0 && listaTopos.Count > 0)
            {
                int randomPos = Random.Range(0, puntosDeSpawn.Count);
                int randomTopo = Random.Range(0, listaTopos.Count);

                Transform puntoSpawn = puntosDeSpawn[randomPos];
                GameObject topo = listaTopos[randomTopo];

                if (topo.activeSelf)
                {
                    topo.GetComponent<MeshRenderer>().enabled = false;
                    topo.SetActive(false);
                }

                topo.SetActive(true);
                topo.transform.position = puntoSpawn.position;
                topo.GetComponent<MeshRenderer>().enabled = true;

                StartCoroutine(DesactivarTopo(topo, tiempoDesaparicion));
            }
        }
    }

    IEnumerator DesactivarTopo(GameObject topo, float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        topo.GetComponent<MeshRenderer>().enabled = false;
        topo.SetActive(false);
    }

    void DesactivarTopos()
    {
        foreach (var topo in toposBuenos)
        {
            topo.SetActive(false);
            topo.GetComponent<MeshRenderer>().enabled = false;
        }

        foreach (var topo in toposMalos)
        {
            topo.SetActive(false);
            topo.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
