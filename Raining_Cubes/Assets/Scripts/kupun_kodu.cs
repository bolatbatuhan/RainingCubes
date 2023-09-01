using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupun_kodu : MonoBehaviour
{

    

    void Update()
    {
        
       transform.Rotate(Vector3.forward * 50 * Time.deltaTime + Vector3.right * 50 * Time.deltaTime + Vector3.up * 50 * Time.deltaTime);
    }
}
