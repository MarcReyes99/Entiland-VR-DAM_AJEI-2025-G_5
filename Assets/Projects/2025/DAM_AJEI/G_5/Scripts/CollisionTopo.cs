using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTopo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Topo"))
        {
            other.gameObject.GetComponent<Topo>().Hit();
        }
    }
}
