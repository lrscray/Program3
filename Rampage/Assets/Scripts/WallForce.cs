using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallForce : MonoBehaviour
{
    [SerializeField] GameObject RightWall;
    [SerializeField] GameObject LeftWall;
    [SerializeField] GameObject BackWall;
    [SerializeField] GameObject FrontWall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //push the enemy away from wall upon collision.
            Rigidbody rw = RightWall.GetComponent<Rigidbody>();
            rw.AddForce(-transform.forward * 5000, ForceMode.VelocityChange);
            rw.useGravity = true;

            Rigidbody lw = LeftWall.GetComponent<Rigidbody>();
            lw.AddForce(-transform.forward * 5000, ForceMode.VelocityChange);
            lw.useGravity = true;

            Rigidbody fw = FrontWall.GetComponent<Rigidbody>();
            fw.AddForce(-transform.forward * 5000, ForceMode.VelocityChange);
            fw.useGravity = true;

            Rigidbody bw = BackWall.GetComponent<Rigidbody>();
            bw.AddForce(-transform.forward * 5000, ForceMode.VelocityChange);
            bw.useGravity = true;
        }
    }
}
