using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
