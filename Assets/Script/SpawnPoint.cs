using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject ob;

    private void Start()
    {
        Instantiate(ob, transform.position, Quaternion.identity);         
    }
}
