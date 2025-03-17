using System.Collections.Generic;
using UnityEngine;

namespace EntilandVR.DosCinco.DAM_AJEI.G_Cinco
{
    public class Topo : MonoBehaviour
    {
        public float spawnTime = 0f;
        public float spawnedTime = 4f;
        public List<GameObject> spawnPoints;

        public bool good;

        int rand;
        GameObject point;

        private void Start()
        {

            spawnPoints = SpawnTopo.instance.puntosDeSpawn;

            rand = Random.Range(0, spawnPoints.Count);

            point = spawnPoints[rand];
        }

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
                spawnedTime = Random.Range(3, 8);
            }
        }

        public void Appear()
        {
            point.GetComponent<SpawnPoint>().inUse = false;

            rand = Random.Range(0, spawnPoints.Count);

            point = spawnPoints[rand];

            while (point.GetComponent<SpawnPoint>().inUse == true)
            {
                rand = Random.Range(0, spawnPoints.Count);

                point = spawnPoints[rand];
            }

            transform.position = point.transform.position;

            transform.rotation = point.transform.rotation;

            point.GetComponent<SpawnPoint>().inUse = true;

            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }

        public void Disappear()
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }

        public void Hit()
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            SpawnTopo.instance.scorePoints++;
            spawnTime = 0f;
        }


    }
}
