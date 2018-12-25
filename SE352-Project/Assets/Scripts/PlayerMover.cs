using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMover : NetworkBehaviour {

    public float MoveSpeed = 10f;
    public float TurnSpeed = 35f;
    public GameObject gun;
    private bool isGunner;
    private bool isCheckpoint;
	
	// Update is called once per frame
	void Update () {

        if (!isLocalPlayer)
        {
            return;
        }

        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        transform.Translate(0, 0, MoveSpeed * move * Time.deltaTime);
        transform.Rotate(0, TurnSpeed * turn * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(isGunner);
        }
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    public void SpeedBuffer(float buff)
    {
        MoveSpeed = MoveSpeed * buff;
        TurnSpeed = TurnSpeed * buff;
    }

    public void SetGunner(bool var)
    {
        isGunner = var;
        return;
    }
    public bool IsGunner()
    {
        return isGunner;
    }

    public void SetCheckpoint(bool var)
    {
        isGunner = var;
        return;
    }
    public bool IsCheckpoint()
    {
        return isCheckpoint;
    }
}
