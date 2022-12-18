using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float speed;
    // public float minspace;
    // public float maxspace;
    // public GameObject top;
    // public GameObject bottom;
    void Start()
    {
        // SetupPipes();

    }
    void Update()
    {
        transform.position += ((Vector3.left * speed) * Time.deltaTime);
    }

    //     void SetupPipes()
    //     {
    //         float temp = Random.Range(-2.86f + minspace, 5);
    //         top.transform.position = new Vector2(0, temp);
    //         float temp2 = Random.Range(minspace, maxspace);
    //         bottom.transform.position = new Vector3(0, temp - temp2);

    //     }
}
