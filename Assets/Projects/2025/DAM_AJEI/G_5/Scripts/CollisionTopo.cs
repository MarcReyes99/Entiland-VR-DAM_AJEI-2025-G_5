using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTopo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Topo")){
            Destroy(other.gameObject);
        }
    }
}
