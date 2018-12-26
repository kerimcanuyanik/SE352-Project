using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Respawn : NetworkBehaviour {

    public GameObject GunnerStartPosition;
    public GameObject RunnerStartPosition;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerMover>().IsGunner())
        {
            if (hasAuthority)
            {
                RpcRespawnPlayer(collision.gameObject, GunnerStartPosition.transform.position);
            }
            else
                CmdRespawnPlayer(collision.gameObject, GunnerStartPosition.transform.position);
        }
        else
        {
            if (hasAuthority)
            {
                RpcRespawnPlayer(collision.gameObject, RunnerStartPosition.transform.position);
            }
            else
                CmdRespawnPlayer(collision.gameObject, RunnerStartPosition.transform.position);
        }
    }

    [Command]
    void CmdRespawnPlayer(GameObject player, Vector3 position)
    {
        RpcRespawnPlayer(player, position);
    }

    [ClientRpc]
    void RpcRespawnPlayer(GameObject player, Vector3 position)
    {
        player.transform.position = position;
    }
}
