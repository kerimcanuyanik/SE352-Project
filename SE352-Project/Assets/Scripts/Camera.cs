using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Camera : NetworkBehaviour {

    public Camera cam;

	// Update is called once per frame
	void Update () {

        if (!isLocalPlayer)
        {
            cam.gameObject.SetActive(false);
            return;
        }

    }
}
