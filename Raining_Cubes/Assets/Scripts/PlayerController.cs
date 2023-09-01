using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{


    float hiz = 10.0f;
    public ParticleSystem efekt;
    public float can = 100.0f;
    public float suan_ki_can;

    Image HealthBar;

    private void Start()
    {
        
        efekt.Stop();
        suan_ki_can = can;
        HealthBar = GameObject.Find("Canvas/HealthBar/Health").GetComponent<Image>();
        HealthBar.fillAmount = suan_ki_can / can;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kup")
        {
            

            efekt.Play();         
            Destroy(collision.gameObject);
            suan_ki_can -= 10.0f;
            HealthBar.fillAmount = suan_ki_can / can;

            
            
        }
    }

   

    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * hiz;
        rotation *= Time.deltaTime;
        transform.Translate(rotation, 0, 0, Space.World);
        
    }
}
