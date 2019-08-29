using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldHc : MonoBehaviour {
       public float flashTime;
       Color origionalColor;
       public SpriteRenderer renderer;
	// Use this for initialization
       void Start()
       {
           origionalColor = renderer.color;
       }
       void FlashWhite()
       {
           renderer.color = Color.white;
           Invoke("ResetColor", flashTime);
       }
       void ResetColor()
       {
           renderer.color = origionalColor;
       }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Rocket")
        {
            FlashWhite();
            Destroy(other.gameObject);
        }
    }
}
