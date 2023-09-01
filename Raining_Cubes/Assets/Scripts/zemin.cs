using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class zemin : MonoBehaviour

    
{
    int skor = 0;

    public TextMeshProUGUI skor_txt;

    public AudioSource ses_dosyasi;
    public AudioClip pat_sesi;

    

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kup")
        {
            ses_dosyasi.PlayOneShot(pat_sesi);
            skor += 10;
            skor_txt.text = skor.ToString();
            Destroy(collision.gameObject);

        }
        

    }

   
}
