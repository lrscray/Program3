using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RunAway : MonoBehaviour
{ //allow player to run away from each enemy spawned
    //ISSUES: player is not running from other enemies
    [SerializeField] private GameObject Enemy;
    [SerializeField] private float TriggerDistance = 4.0f;

    private NavMeshAgent Player;

    void Start()
    {
        Player = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
      /*foreach (GameObject r in Enemies)
        {
          
        }*/
        float distance = Vector3.Distance(transform.position, Enemy.transform.position);
        
        //track distance
        Debug.Log("Distance: " + distance);

        if (distance < TriggerDistance)
        {
            //distance to enemy
            Vector3 toEnemy = transform.position - Enemy.transform.position;
            //adjust distance
            Vector3 newPos = transform.position + toEnemy;

            Player.SetDestination(newPos);
        }
    }
}
