using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenPlatform : MonoBehaviour
{
    float hiz = 10.0f;
    
    

    // Update is called once per frame
    void Update()
    {
        float rotationH = Input.GetAxis("Horizontal") * hiz;
        rotationH = rotationH * Time.deltaTime;
        transform.Translate(rotationH, 0, 0, Space.World);
    }
}
