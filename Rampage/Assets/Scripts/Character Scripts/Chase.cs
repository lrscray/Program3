using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//cant use navmesh without this
using UnityEngine.AI;

public class Chase : MonoBehaviour
{

    //distance to chase player
    [SerializeField] float chaseDistance = 100f;

    public GameObject Player;

    NavMeshAgent theNav;

    public void Start()
    { 

        theNav = this.GetComponent<NavMeshAgent>();

        //check that nav mesh is attached
        if (theNav == null)
        {
            Debug.LogError("nav mesh component not attached to " + gameObject.name);
        }
    }

    public void Update()
    {
        chasePlayer();

    }

    private void chasePlayer()
    {
        //defining distance in terms of enemies and player
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        //Chase after them if player gets too close
        if (distance < chaseDistance)
        {
            Vector3 changeDirection = transform.position - Player.transform.position;

            Vector3 newPosition = transform.position - changeDirection;

            theNav.SetDestination(newPosition);

        }
    }
}

