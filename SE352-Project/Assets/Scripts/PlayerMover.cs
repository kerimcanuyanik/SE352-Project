using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

    public float MoveSpeed = 10f;
    public float TurnSpeed = 25f;
	
	// Update is called once per frame
	void Update () {

        float rightSpeed = Input.GetAxis("Horizontal");

        float upSpeed = Input.GetAxis("Vertical");

        transform.Translate(0, 0, MoveSpeed * upSpeed * Time.deltaTime);
        transform.Rotate(0, TurnSpeed * rightSpeed * Time.deltaTime, 0);
    }
}
