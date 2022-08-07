using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    int collisionCounter = 0;
    
    private void OnCollisionEnter(Collision collision)
    {   
        if (collision.gameObject.CompareTag("Enemy tag"))
        {
            collisionCounter++;
            
            // If player touch enemies 3 times -> die
            if (collisionCounter == 3)
            {
                Die();
            }
            else
            {
                // 血量减少，播放受到攻击的音效
                Debug.Log("attacked!!!");
            }
            
        }
    }

    void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false;
        
    }
}
