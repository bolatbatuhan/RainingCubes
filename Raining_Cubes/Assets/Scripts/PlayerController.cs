using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    
    
    public float hiz;
    public ParticleSystem efekt;
    float can = 100.0f;
    float suan_ki_can = 100.0f;

    Image HealthBar;

    private void Start()
    {
        efekt.Stop();
        HealthBar = GameObject.Find("Canvas/HealthBar/Health").GetComponent<Image>();

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
        if(Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }
        
    }
}
