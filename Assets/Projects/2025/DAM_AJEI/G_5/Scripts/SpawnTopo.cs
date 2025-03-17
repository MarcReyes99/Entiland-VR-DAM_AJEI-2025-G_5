using System.Collections.Generic;
using UnityEngine;

namespace EntilandVR.DosCinco.DAM_AJEI.G_Cinco
{
    public class SpawnTopo : MonoBehaviour
    {
        public List<GameObject> puntosDeSpawn;
        public int scorePoints = 0;
        public TextMesh scoretext;

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

        private void Update()
        {
            scoretext.text = scorePoints.ToString();
        }

    }
}
