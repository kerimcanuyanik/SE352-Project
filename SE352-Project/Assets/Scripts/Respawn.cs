using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Respawn : NetworkBehaviour {

    public GameObject GunnerStartPosition;
    public GameObject RunnerStartPosition;
    public GameObject CheckpointPosition;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerMover>().IsGunner())
        {
            CmdRespawnPlayer(collision.gameObject, GunnerStartPosition.transform.position);
        }
        else if(!collision.gameObject.GetComponent<PlayerMover>().IsGunner() && !collision.gameObject.GetComponent<PlayerMover>().IsCheckpoint())
        {
            CmdRespawnPlayer(collision.gameObject, RunnerStartPosition.transform.position);
        }
        else if(!collision.gameObject.GetComponent<PlayerMover>().IsGunner() && collision.gameObject.GetComponent<PlayerMover>().IsCheckpoint())
        {
            CmdRespawnPlayer(collision.gameObject, CheckpointPosition.transform.position);
        }

    }

    [Command]
    void CmdRespawnPlayer(GameObject player, Vector3 position)
    {
        player.transform.position = position;
    }
}
