using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public float startWait;
    public float SpawnWait;
    public float WaveWait;
    public int MeteorsPerWave;
    public Vector3 SpawnValues;
    public GameObject Met;
    
    private bool gameOver;
    private bool Restart;
	// Use this for initialization
   
	void Start () {
        StartCoroutine(SpawnWaves());
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < MeteorsPerWave; i++)
            {

                Vector3 SpawnPosition = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x), SpawnValues.y, -5.33f);
                Quaternion SpawnRotation = Quaternion.identity;
                Instantiate(Met, SpawnPosition, SpawnRotation);
                yield return new WaitForSeconds(SpawnWait);
            }
            yield return new WaitForSeconds(WaveWait);
        }
    }
     

}
