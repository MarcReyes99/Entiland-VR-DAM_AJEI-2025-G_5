using UnityEngine;

namespace EntilandVR.DosCinco.DAM_AJEI.G_Cinco
{
    public class CollisionTopo : MonoBehaviour
    {
        public void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.gameObject.name);
            if (other.gameObject.CompareTag("Obstacle"))
            {
                other.gameObject.GetComponent<Topo>().Hit();
            }
        }
    }
}