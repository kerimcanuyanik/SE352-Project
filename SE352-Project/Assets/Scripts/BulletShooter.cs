using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform BulletSpawn;



    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }


    void Fire()
    {
        var bullet = (GameObject)Instantiate(
            BulletPrefab,
            BulletSpawn.position,
            BulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;

        Destroy(bullet, 10f);
    }
}
