using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ob;

    private float timebtwspwan;
    public float startTimebtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timebtwspwan <= 0)
        {
            Instantiate(ob[Random.Range(0,ob.Length)], transform.position, Quaternion.identity);
            timebtwspwan = startTimebtwSpawn;
            if(startTimebtwSpawn >= minTime)
            {
                startTimebtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timebtwspwan -= Time.deltaTime;
        }
    }
}
