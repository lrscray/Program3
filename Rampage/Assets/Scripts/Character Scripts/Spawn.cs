using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //Spawn enemies randomly within given parameters
    [SerializeField] GameObject Enemy;
    [SerializeField] float xMin = -10f;
    [SerializeField] float xMax = 10f;
    [SerializeField] float zMin = -10f;
    [SerializeField] float zMax = 10f;
    [SerializeField] float initialHeight = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            SpawnEnemy();
        }
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }

    void SpawnEnemy()
    { //have enemies fire out of their spawn points
        Vector3 Position = new Vector3(Random.Range(xMin, xMax), initialHeight, Random.Range(zMin, zMax));
        GameObject BadGuy = Instantiate(Enemy);
        BadGuy.transform.position = Position;
        Rigidbody rb = BadGuy.GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(Random.Range(0, 5), Random.Range(0, 5), Random.Range(0, 5)));
        BadGuy.SetActive(true);
        rb.AddForce(transform.forward * 1000, ForceMode.Acceleration);
        rb.useGravity = true;
    }
}
