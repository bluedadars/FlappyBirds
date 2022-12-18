using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    void Start()
    {
        // transform.position = new Vector3(MyVector2.down().x, MyVector2.down().y, 0f);
    }
    void Update()
    {
        movementFunction();

    }
    void movementFunction()
    {
        transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
    }


}
