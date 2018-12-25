using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<PlayerMover>().SetCheckpoint(true);
    }
}
