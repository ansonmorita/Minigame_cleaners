using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    int collisionCounter = 0;
    
    int life = 3;
    [SerializeField] Text lifeTxt;
    public TextMeshProUGUI diedTxt;
    
    void Start()
    {
        diedTxt.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {   
        if (collision.gameObject.CompareTag("Enemy tag"))
        {
            collisionCounter++;
            
            // If player touch enemies 3 times -> die
            if (collisionCounter == 3)
            {
                Die();
                life = 0;
                lifeTxt.text = life.ToString();
            }
            else
            {
                // -1 life
                //Debug.Log("attacked!!!");
                life--;
                lifeTxt.text = life.ToString();
            }
            
        }
    }

    void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false;
        
        //Died scene
        Time.timeScale = 0f;
        diedTxt.enabled = true;

    }
}
