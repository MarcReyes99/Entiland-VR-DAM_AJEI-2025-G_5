using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTopo : MonoBehaviour
{
    public GameObject toppo;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Topo")){
            Destroy(other.gameObject);
        }
    }
}
