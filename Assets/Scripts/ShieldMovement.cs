using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldMovement : MonoBehaviour
{

    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            float NewPos = Mathf.Lerp(transform.position.x, mousePosition.x, moveSpeed);
            transform.position = new Vector3(NewPos, transform.position.y, transform.position.z);
    }
}