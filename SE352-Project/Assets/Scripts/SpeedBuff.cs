﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpeedBuff : NetworkBehaviour {

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            CmdActiveSpeedBuff(collider.gameObject, 2f);

            Debug.Log("Speed Up");

            CmdDestroy();
        }
    }

    [Command]
    void CmdActiveSpeedBuff(GameObject player, float buff)
    {
        player.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        player.gameObject.GetComponent<PlayerMover>().SpeedBuffer(buff);
    }

    [Command]
    void CmdDestroy()
    {
        Destroy(this);
    }
}
