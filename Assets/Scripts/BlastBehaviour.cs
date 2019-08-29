using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastBehaviour : MonoBehaviour {

    public Vector3 MaxRadius;
    public float ExplosionSpeed;
    float desTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //lerp the scale then destroy 
        transform.localScale = Vector3.Lerp(transform.localScale, MaxRadius, ExplosionSpeed * Time.deltaTime);
       
        desTime += Time.deltaTime;
        if(desTime>1)
        {
            Destroy(gameObject);
        }
        
	}
}
