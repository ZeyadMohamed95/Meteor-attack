using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandHE : MonoBehaviour
{
    public GameObject explosion;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Rocket")
        {
            Instantiate(explosion, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
    }
}

