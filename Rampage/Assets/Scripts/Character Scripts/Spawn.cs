using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //Spawn enemies randomly within given parameters
    [SerializeField] private GameObject Enemy;

    // Update is called once per frame
    void FixedUpdate()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }

}
