using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject[] walkpoints;
    int currentWP = 0; // current walkpoint index

    [SerializeField] float speed = 1f;
    
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, walkpoints[currentWP].transform.position) < 0.1f)
        {   // Touched the goal point, switch to next one
            currentWP++;
            if (currentWP >= walkpoints.Length)
            {
                currentWP = 0;
            }
        }
        
        transform.position = Vector3.MoveTowards(transform.position, walkpoints[currentWP].transform.position, speed*Time.deltaTime);
    }
}
