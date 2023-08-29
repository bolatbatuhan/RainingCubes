using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class zemin : MonoBehaviour
{
    int skor = 0;

    public TextMeshProUGUI skor_txt;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kup")
        {
            skor += 10;
            skor_txt.text = skor.ToString();
            Destroy(collision.gameObject);

        }
        

    }

   
}
