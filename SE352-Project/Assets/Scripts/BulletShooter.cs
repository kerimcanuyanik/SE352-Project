using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BulletShooter : NetworkBehaviour {

    public GameObject BulletPrefab;
    public Transform BulletSpawn;
    public GameObject Gun;

    void Update()
    {
        if (Gun.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                CmdFire();
            }
        }
    }

    [Command]
    void CmdFire()
    {
        GameObject bullet = Instantiate(
            BulletPrefab,
            BulletSpawn.position,
            BulletSpawn.rotation) as GameObject;

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 25;

        NetworkServer.Spawn(bullet);

        Destroy(bullet, 10f);
    }
}
