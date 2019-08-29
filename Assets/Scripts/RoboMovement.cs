using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoboMovement : MonoBehaviour {
    public Transform Point1,Point2;
    int dest;
    public float speed;
    public float MiningTime;
    public Text ScoreText;
    int Score=0;
    private float timer=0;
    
	// Use this for initialization
	void Start () {
        dest = 1;
        ScoreText.text = "Score:" + Score;
	}
	
	// Update is called once per frame
	void Update () {
        
        if (dest==2)
        {
            transform.position = Vector3.MoveTowards(transform.position, Point2.position, speed * Time.deltaTime);
            if(Vector3.Distance(transform.position, Point2.position)<0.5f)
            {
                dest = 1;
            }
        }
        if (dest==1)
          {
              transform.position = Vector3.MoveTowards(transform.position, Point1.position, speed * Time.deltaTime);
              if (Vector3.Distance(transform.position, Point1.position) < 0.5f)
                 {
                    timer += Time.deltaTime;
                    if (timer > MiningTime)
                    {
                        dest = 2;
                        timer= 0;
                        Score++;
                        ScoreText.text = "Score:" + Score;
                    }
                }
          }
        }
	}

