using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorBehaviour : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb;
    private Vector2 dir;
    private CircleCollider2D cir;
    
	// Use this for initialization
    void Awake () 
    {
        rb = GetComponent<Rigidbody2D>();
        dir = new Vector2(0,-90f);
        cir = GetComponent<CircleCollider2D>();
        cir.transform.position = gameObject.transform.position;
    }
    void FixedUpdate()
    {
        rb.AddForce(dir *speed*Time.deltaTime);
    }
}
