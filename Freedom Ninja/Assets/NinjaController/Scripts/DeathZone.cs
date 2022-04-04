using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject deathScreen;
    public GameObject uiCamera;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            deathScreen.SetActive(true);
            uiCamera.SetActive(true);  
        }

        
        
    }


}
