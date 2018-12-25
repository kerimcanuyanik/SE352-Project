using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ShieldBuff : NetworkBehaviour {

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            CmdActiveShieldBuff(collider.gameObject);

            Debug.Log("Shield Up");

            CmdDestroy();
        }
    }

    [Command]
    void CmdActiveShieldBuff(GameObject player)
    {
        player.gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }

    [Command]
    void CmdDestroy()
    {
        Destroy(this);
    }
}
