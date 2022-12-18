using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform targetPosition;
    public Vector3 offset;
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 myPosition = targetPosition.position + offset;
        transform.position = myPosition;

    }
}
