using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yonetici : MonoBehaviour
{
   

    public GameObject kup;
    void Start()
    {
        InvokeRepeating("kup_ekle", 0.0f, 2.5f);
    }

    void kup_ekle()
    {
        
        float rast = Random.Range(-39.0f,39.0f);
        GameObject yeni_kup = Instantiate(kup,new Vector3(rast,22,35f),Quaternion.identity);
        
    }

    private void Update()
    {
        
            

    }
}
