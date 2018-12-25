using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPlatformer : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        collision.gameObject.GetComponent<PlayerMover>().SetGunner(true);
    }
}
