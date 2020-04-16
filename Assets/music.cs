using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public GameObject background_sound;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(background_sound, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
