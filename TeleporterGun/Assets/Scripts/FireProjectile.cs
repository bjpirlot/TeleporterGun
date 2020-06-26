using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPoint;

    // Start is called before the first frame update
   

    private void fire()
    {
        Vector3 position = spawnPoint.position;
        Quaternion rotation = spawnPoint.rotation;

        Instantiate(projectile, position, rotation);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire();
        }


    }
}
