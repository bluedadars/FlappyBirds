using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public Transform groundSpawn;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Resposition();
    }
    public void Resposition()
    {
        if (transform.position.x <= -groundSpawn.position.x)
        {
            transform.position = groundSpawn.position;
        }
    }
}
