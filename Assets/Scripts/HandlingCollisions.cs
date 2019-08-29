using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlingCollisions : MonoBehaviour {
	// Use this for initialization
    public GameObject blast;
    private bool BlastHit=false;
    private Renderer rend;
    private GameObject childrocket;
    private Rigidbody2D rb2d;
    
    void Awake()
    {
        childrocket = gameObject.transform.Find("rocket").gameObject;
        rb2d = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag =="Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
        if (other.gameObject.tag == ("Ground") || other.gameObject.tag == ("shield"))
        {
         //   rb2d.GetComponent<Rigidbody2D>().enabled = false;
            Destroy(gameObject);
           
        }
    }

}


