using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BulletShooter : NetworkBehaviour {

    public GameObject BulletPrefab;
    public Transform BulletSpawn;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CmdFire();
        }
    }

    [Command]
    void CmdFire()
    {
        GameObject bullet = Instantiate(
            BulletPrefab,
            BulletSpawn.position,
            BulletSpawn.rotation) as GameObject;

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;

        NetworkServer.Spawn(bullet);

        Destroy(bullet, 10f);
    }
}
